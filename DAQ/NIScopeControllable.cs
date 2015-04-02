using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAQ.NIScope
{
    public interface NIScopeControllable
    {
        double[,] GetShot();
        void ArmAndWait();
        void StartAcquisition(string channelName, double sampleRate, double referencePosition,
            double range, int numberOfPoints, int numberOfRecords);
        void StartScan();
        void FinishScan();
        void FinishAcquisition();

    }
}
