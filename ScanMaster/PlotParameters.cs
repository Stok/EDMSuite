using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMaster.GUI
{
    public class PlotParameters
    {
        public double Maximum, Minimum;
        public int PointsPerRange;
        public PlotParameters(double min, double max)
        {
            Maximum = max;
            Minimum = min;
            PointsPerRange = (int)GetInterval();
        }
        public PlotParameters(double min, double max, int pointsPerRange)
        {
            Maximum = max;
            Minimum = min;
            PointsPerRange = pointsPerRange;
        }
        public double GetInterval()
        {
            return Maximum - Minimum;
        }
            
    }
}
