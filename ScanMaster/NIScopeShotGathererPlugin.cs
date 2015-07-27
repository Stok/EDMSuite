using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using DAQ.NIScope;

using Data;
using ScanMaster.Acquire.Plugin;

namespace ScanMaster.Acquire.Plugin
{
    [Serializable]
    public class NIScopeShotGathererPlugin : ShotGathererPlugin
    {
        [NonSerialized]
        private NIScopeControllable scope;

        public override void ArmAndWait()
        {
            scope.ArmAndWait();
        }

        public override Data.Shot Shot
        {
            get 
            { 
                lock(this)
                {
                    Data.Shot s = new Data.Shot();
                    Data.TOF t = new TOF();
                    t.ClockPeriod = (int)settings["clockPeriod"];
                    t.GateStartTime = (int)settings["gateStartTime"];
                    t.Data = scope.GetShot();
                    s.TOFs.Add(t);
                    return s;
                }
            }
        }

        protected override void InitialiseSettings()
        {
            settings["channelName"] = "0";
            settings["sampleRate"] = 100000000;
            settings["referencePosition"] = 50.0;
            settings["inputRangePlusMinus"] = 10.0;
            settings["numberOfPoints"] = 100;
            settings["numberOfRecords"] = 1;
            settings["inputRangeLow"] = 0.0;
            settings["inputRangeHigh"] = 0.0;
            
        }

        public override void AcquisitionStarting()
        {
            scope = (NIScopeControllable)Activator.GetObject(typeof(NIScopeControllable),
"tcp://localhost:1172/controller.rem");

            scope.StartAcquisition((string)settings["channelName"], Convert.ToDouble((int)settings["sampleRate"] / (int)settings["clockPeriod"]), 
                (double)settings["referencePosition"], (double)settings["inputRangePlusMinus"], 
                (int)settings["gateLength"], (int)settings["numberOfRecords"]);
        }

        public override void ScanStarting()
        {
            scope.StartScan();
        }

        public override void ScanFinished()
        {
            scope.FinishScan();
        }

        public override void AcquisitionFinished()
        {
            scope.FinishAcquisition();
        }
    }
}
