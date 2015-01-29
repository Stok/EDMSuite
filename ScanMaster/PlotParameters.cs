using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMaster.GUI
{
    public class PlotParameters
    {

        public double Maximum, Minimum, Interval;
        public int PointsPerRange;

        public PlotParameters(double min, double max)
        {
            Maximum = max;
            Minimum = min;
            Interval = Maximum - Minimum;
            PointsPerRange = (int)Interval;
        }
        public PlotParameters(double min, double max, int pointsPerRange)
        {
            Maximum = max;
            Minimum = min;
            Interval = Maximum - Minimum;
            PointsPerRange = pointsPerRange;
        }

    }
}
