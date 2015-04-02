using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using System.Drawing;

using NationalInstruments;
using NationalInstruments.DAQmx;

using DAQ;
using DAQ.HAL;
using DAQ.Environment;
using DAQ.NIScope;



namespace ParityHardwareControl
{
    /// <summary>
    /// A Hardware controller for the Parity experiment. 
    /// For the moment, it's just operates the fast NI card and does a few DAQmx operations.
    /// 
    /// </summary>
    public class Controller : MarshalByRefObject, NIScopeControllable
    {
        #region Constants
        //Put any constants and stuff here
        private static string profilesPath = (string)Environs.FileSystem.Paths["settingsPath"]
            + "ParityHardwareController\\";

        private static Hashtable calibrations = Environs.Hardware.Calibrations;
        #endregion

        #region Setup

        // Declare that there will be a controlWindow
        ControlWindow controlWindow;

        //There will be some 'slow' analog and digital tasks
        Dictionary<string, Task> analogTasks;
        Hashtable digitalTasks = new Hashtable();

        NIScopeControlHelper scope;

        // without this method, any remote connections to this object will time out after
        // five minutes of inactivity.
        // It just overrides the lifetime lease system completely.
        public override Object InitializeLifetimeService()
        {
            return null;
        }

        public void Start()
        {
            // make the digital analogTasks. The function "CreateDigitalTask" is defined later
            //e.g   CreateDigitalTask("notEOnOff");
            //      CreateDigitalTask("eOnOff");

            //This is to keep track of the various things which the HC controls.
            analogTasks = new Dictionary<string, Task>();

            //CreateDigitalTask("aom0enable");
          
            // make the analog output analogTasks. The function "CreateAnalogOutputTask" is defined later
            //e.g.  bBoxAnalogOutputTask = CreateAnalogOutputTask("b");
            //      steppingBBiasAnalogOutputTask = CreateAnalogOutputTask("steppingBBias");

            //CreateAnalogOutputTask("aom0amplitude");
            
           // CreateAnalogInputTask("laserLockErrorSignal", -10, 10);
          
            // make the control controlWindow
            controlWindow = new ControlWindow();
            controlWindow.controller = this;

            scope = new NIScopeControlHelper();
            System.Console.Out.Write("Startup complete. Opening control window. \n");
            Application.Run(controlWindow);
        }
        
        #endregion

        #region private methods for creating un-timed Tasks/channels
        // a list of functions for creating various analogTasks
        private void CreateAnalogInputTask(string channel)
        {
            analogTasks[channel] = new Task(channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                analogTasks[channel],
                0,
                10
            );
            analogTasks[channel].Control(TaskAction.Verify);
        }

        // an overload to specify input range
        private void CreateAnalogInputTask(string channel, double lowRange, double highRange)
        {
            analogTasks[channel] = new Task(channel);
            ((AnalogInputChannel)Environs.Hardware.AnalogInputChannels[channel]).AddToTask(
                analogTasks[channel],
                lowRange,
                highRange
            );
            analogTasks[channel].Control(TaskAction.Verify);
        }


        private void CreateAnalogOutputTask(string channel)
        {
            analogTasks[channel] = new Task(channel);
            AnalogOutputChannel c = ((AnalogOutputChannel)Environs.Hardware.AnalogOutputChannels[channel]);
            c.AddToTask(
                analogTasks[channel],
                c.RangeLow,
                c.RangeHigh
                );
            analogTasks[channel].Control(TaskAction.Verify);
        }

        // setting an analog voltage to an output
        public void SetAnalogOutput(string channel, double voltage)
        {
            SetAnalogOutput(channel, voltage, false);
        }
        //Overload for using a calibration before outputting to hardware
        public void SetAnalogOutput(string channelName, double voltage, bool useCalibration)
        {
            
            AnalogSingleChannelWriter writer = new AnalogSingleChannelWriter(analogTasks[channelName].Stream);
            double output;
            if (useCalibration)
            {
                try
                {
                    output = ((Calibration)calibrations[channelName]).Convert(voltage);
                }
                catch (DAQ.HAL.Calibration.CalibrationRangeException)
                {
                    MessageBox.Show("The number you have typed is out of the calibrated range! \n Try typing something more sensible.");
                    throw new CalibrationException();
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    throw new CalibrationException();
                }
            }
            else
            {
                output = voltage;
            }
            try
            {
                writer.WriteSingleSample(true, output);
                analogTasks[channelName].Control(TaskAction.Unreserve);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public class CalibrationException : ArgumentOutOfRangeException { };
        // reading an analog voltage from input
        public double ReadAnalogInput(string channel)
        {
            return ReadAnalogInput(channel, false);
        }
        public double ReadAnalogInput(string channelName, bool useCalibration)
        {
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogTasks[channelName].Stream);
            double val = reader.ReadSingleSample();
            analogTasks[channelName].Control(TaskAction.Unreserve);
            if (useCalibration)
            {
                try
                {
                    return ((Calibration)calibrations[channelName]).Convert(val);
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    return val;
                }
            }
            else
            {
                return val;
            }
        }
        
        // overload for reading multiple samples
        public double ReadAnalogInput(string channel, double sampleRate, int numOfSamples, bool useCalibration)
        {
            //Configure the timing parameters of the task
            analogTasks[channel].Timing.ConfigureSampleClock("", sampleRate,
                SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, numOfSamples);

            //Read in multiple samples
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogTasks[channel].Stream);
            double[] valArray = reader.ReadMultiSample(numOfSamples);
            analogTasks[channel].Control(TaskAction.Unreserve);

            //Calculate the average of the samples
            double sum = 0;
            for (int j = 0; j < numOfSamples; j++)
            {
                sum = sum + valArray[j];
            }
            double val = sum / numOfSamples;
            if (useCalibration)
            {
                try
                {
                    return ((Calibration)calibrations[channel]).Convert(val);
                }
                catch
                {
                    MessageBox.Show("Calibration error");
                    return val;
                }
            }
            else
            {
                return val;
            }
        }


        private void CreateDigitalTask(String name)
        {
           
            Task digitalTask = new Task(name);
            ((DigitalOutputChannel)Environs.Hardware.DigitalOutputChannels[name]).AddToTask(digitalTask);
            digitalTask.Control(TaskAction.Verify);
            digitalTasks.Add(name, digitalTask);
        }

        public void SetDigitalLine(string name, bool value)
        {
            Task digitalTask = ((Task)digitalTasks[name]);
            DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(digitalTask.Stream);
            writer.WriteSingleSampleSingleLine(true, value);
            digitalTask.Control(TaskAction.Unreserve);
        }

        #endregion


        #region Remoting stuff

        /// <summary>
        /// These SetValue functions are for giving commands to the hc from another program, while keeping the hc in control of hardware.
        /// Use this if you want the HC to keep control, but you want to control the HC from some other program
        /// </summary>
        public void SetValue(string channel, double value)
        {
            SetAnalogOutput(channel, value, false);
        }
        public void SetValue(string channel, double value, bool useCalibration)
        {
            SetAnalogOutput(channel, value, useCalibration);
        }
        public void SetValue(string channel, bool value)
        {
            SetDigitalLine(channel, value);
        }
        #endregion
        

        

        #region The Fast NIScope card

        public double[,] GetShot()
        {
            return scope.GetShot();
        }

        public void ArmAndWait()
        {
            scope.ArmAndWait();
        }

        public void StartAcquisition(string channelName, double sampleRate, double referencePosition,
            double range, int numberOfPoints, int numberOfRecords)
        {
            System.Console.Out.Write("Initialising NI-Scope card and starting acquisition...");
            scope.StartAcquisition(channelName, sampleRate, referencePosition,
            range, numberOfPoints, numberOfRecords);
            System.Console.Out.Write("complete.\n");
        }

        public void StartScan()
        {
            scope.StartScan();
        }

        public void FinishScan()
        {
            scope.FinishScan();
        }

        public void FinishAcquisition()
        {
            System.Console.Out.Write("Finishing acquisition on NI-Scope card.");
            scope.FinishAcquisition();
        }

        #endregion
    }
}
