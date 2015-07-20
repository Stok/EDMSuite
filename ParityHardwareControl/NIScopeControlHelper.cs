using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments;
using NationalInstruments.ModularInstruments.SystemServices.DeviceServices;
using NationalInstruments.ModularInstruments.NIScope;

using DAQ.NIScope;
using DAQ.HAL;

namespace ParityHardwareControl
{
    public class NIScopeControlHelper : NIScopeControllable
    {
        NIScope scopeSession;
        double[] shot;
        long recordLength;
        PrecisionTimeSpan timeout;
        AnalogWaveformCollection<double> waveforms;
        ModularInstrumentsSystem scopeDevices;
        string scopeName, channelName;


       
        void DriverOperation_Warning(object sender, ScopeWarningEventArgs e)
        {
            MessageBox.Show(e.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public double[] GetShot()
        {
            return waveforms[0].GetRawData();
        }
        public void ArmAndWait()
        {
            try
            {
                waveforms = scopeSession.Channels[channelName].Measurement.Read(timeout, recordLength, waveforms);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            
        }

        public void StartAcquisition(string channelName, double sampleRate, double referencePosition,
            double range, int numberOfPoints, int numberOfRecords)
        {
            try
            {
                scopeDevices = new ModularInstrumentsSystem("NI-Scope");
                scopeName = scopeDevices.DeviceCollection[0].Name;
                scopeSession = new NIScope(scopeName, false, true);
                scopeSession.DriverOperation.Warning += new EventHandler<ScopeWarningEventArgs>(DriverOperation_Warning);

                double offset = 0.0;
                ScopeVerticalCoupling coupling = ScopeVerticalCoupling.DC;
                double probeAttenuation = 1.0;
                scopeSession.Channels[channelName].Configure(range, offset, coupling, probeAttenuation, true);



                bool enforceRealtime = true;

                scopeSession.Timing.ConfigureTiming
                    (sampleRate, numberOfPoints, referencePosition, numberOfRecords, enforceRealtime);

                double triggerLevel = 0.0;
                ScopeTriggerSlope triggerSlope = ScopeTriggerSlope.Positive;
                ScopeTriggerCoupling triggerCoupling = ScopeTriggerCoupling.DC;
                PrecisionTimeSpan triggerHoldoff = PrecisionTimeSpan.Zero;
                PrecisionTimeSpan triggerDelay = PrecisionTimeSpan.Zero;
                ScopeTriggerSource triggerSource = ScopeTriggerSource.External;

                scopeSession.Trigger.EdgeTrigger.Configure
                    (triggerSource, triggerLevel, triggerSlope, triggerCoupling, triggerHoldoff, triggerDelay);

                recordLength = scopeSession.Acquisition.RecordLength;
                sampleRate = scopeSession.Acquisition.SampleRate;
                this.channelName = channelName;

                scopeSession.Measurement.Initiate();


                timeout = new PrecisionTimeSpan(5.0);


            }
            catch (Exception ex)
            {
                ShowError(ex);
            }

        }
        static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void StartScan()
        {

            //throw new NotImplementedException();
        }

        public void FinishScan()
        {

            //throw new NotImplementedException();
        }

        public void FinishAcquisition()
        {
            //throw new NotImplementedException();
            scopeSession.Close();
        }
    }
}
