using System;
using System.Collections;

using NationalInstruments.DAQmx;

using DAQ.Pattern;
using DAQ.Remoting;

namespace DAQ.HAL
{
	
	/// <summary>
	/// This is the specific hardware that the sympathetic cooling experiment has. This class conforms
	/// to the Hardware interface.
	/// </summary>
	public class D006MMTFZ400Hardware : DAQ.HAL.Hardware
	{

        public D006MMTFZ400Hardware()
		{
            Boards.Add("testBoard1", "/dev1");
            string TCLBoard = (string)Boards["testBoard1"];
            Boards.Add("testBoard2", "/dev2");
            string TCLBoard2 = (string)Boards["testBoard2"];

            Info.Add("analogTrigger2", TCLBoard + "/PFI0"); 
            //TCL Lockable lasers
            Info.Add("TCLLockableLasers", new string[] { "laser" });
            Info.Add("TCLPhotodiodes", new string[] { "cavity", "master", "p1" });// THE FIRST TWO MUST BE CAVITY AND MASTER PHOTODIODE!!!!
            Info.Add("TCL_Slave_Voltage_Limit_Upper",5.0); //volts: Laser control
            Info.Add("TCL_Slave_Voltage_Limit_Lower", 0.0); //volts: Laser control
            Info.Add("TCL_Default_Gain", 0.5);
            Info.Add("TCL_Default_VoltageToLaser", 0.0);
            Info.Add("TCL_MAX_INPUT_VOLTAGE", 10.0);
            Info.Add("TCL_Default_ScanPoints", 100);
            Info.Add("TCLReadAutostart", true);

            // Some matching up for TCL
            Info.Add("laser", "p1");
            Info.Add("laser2", "p2");

            AddAnalogInputChannel("p1", TCLBoard + "/ai0", AITerminalConfiguration.Rse);//Pin 2
            AddAnalogInputChannel("p2", TCLBoard + "/ai1", AITerminalConfiguration.Rse);//Pin 5
            AddAnalogInputChannel("cavity", TCLBoard + "/ai2", AITerminalConfiguration.Rse); //Pin 8
            AddAnalogInputChannel("master", TCLBoard + "/ai3", AITerminalConfiguration.Rse); //Pin 8

            //map the analog output channels
            AddAnalogOutputChannel("laser", TCLBoard2 + "/ao0",0,5); // Pin 22
            AddAnalogOutputChannel("rampfb", TCLBoard2 + "/ao1",0,5); 
            //AddAnalogOutputChannel("cavity", TCLBoard2 + "/ao1"); // Pin 21
		}

        public override void ConnectApplications()
        {
           // RemotingHelper.ConnectDecelerationHardwareControl();
        }


	}
}