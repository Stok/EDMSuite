using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMaster
{
    public class Range
    {

        public double Maximum, Minimum, Interval;

        public Range(double min, double max)
        {
            Maximum = max;
            Minimum = min;
            Interval = Maximum - Minimum;
        }

    }
}
