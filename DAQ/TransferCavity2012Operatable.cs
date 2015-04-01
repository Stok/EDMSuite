using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAQ.TransferCavityLock2012
{
    public interface TransferCavity2012Operatable
    {
        void SetLaserSetpoint(string laserName, double newSetPoint);
    }
}
