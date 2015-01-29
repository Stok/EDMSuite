using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows;

namespace ScanMaster.GUI
{
    /// <summary>
    /// A User control for a Chart that has two controllable cursors.
    /// </summary>
    public partial class TwoCursorChart : UserControl
    {
        public event EventHandler LowCursorValueChanged, HighCursorValueChanged;
        private PlotParameters chartRange;
        
        public TwoCursorChart()
        {
            InitializeComponent();
        }

        internal Series GetSeriesByName(string name)
        {
            return chart.Series.FindByName(name);
        }

        private void moveLowCursorHelper(double x)
        {
            lock (this)
            {
                this.GetSeriesByName("lowCursor").Points.Clear();
                this.GetSeriesByName("lowCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum + 1);
                this.GetSeriesByName("lowCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Maximum - 1);
            }
        }
        public void UpdateLowCursorPosition(double x)
        {
            chart.Invoke(new MoveCursorDelegate(moveLowCursorHelper), new Object[] { x });
        }

        private void moveHighCursorHelper(double x)
        {
            lock (this)
            {
                this.GetSeriesByName("highCursor").Points.Clear();
                this.GetSeriesByName("highCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum + 1);
                this.GetSeriesByName("highCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Maximum - 1);
            }
        }
        public void UpdateHighCursorPosition(double x)
        {
            chart.Invoke(new MoveCursorDelegate(moveHighCursorHelper), new Object[] { x });
            
        }
        private delegate void MoveCursorDelegate(double x);

        #region events
        private void lowTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if(this.LowCursorValueChanged!=null)
            {
                UpdateLowCursorPosition(lowTrackBar.Value);
                this.LowCursorValueChanged(this, e);
            }
        }

        private void highTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (this.HighCursorValueChanged != null)
            {
                UpdateHighCursorPosition(highTrackBar.Value);
                this.HighCursorValueChanged(this, e);
            }
        }
        #endregion

        #region Getting the cursor values
        private delegate double getValueDelegate();
        public double GetLowCursorValue()
        {
            return (double)chart.Invoke(new getValueDelegate(getLowCursorValueHelper));
        }
        private double getLowCursorValueHelper()
        {
            double newValue =  (lowTrackBar.Value / (double)chartRange.PointsPerRange) * chartRange.Interval + chartRange.Minimum;;
            return newValue;
        }
        public double GetHighCursorValue()
        {
            return (double)chart.Invoke(new getValueDelegate(getHighCursorValueHelper));
        }
        private double getHighCursorValueHelper()
        {
            return (highTrackBar.Value / (double)chartRange.PointsPerRange) * chartRange.Interval + chartRange.Minimum;
        }
        #endregion

        private delegate void setChartRangeDelegate(PlotParameters x);
        private void setChartRangeHelper(PlotParameters x)
        {
            chartRange = x;
            chart.ChartAreas[0].AxisX.Minimum = x.Minimum;
            chart.ChartAreas[0].AxisX.Maximum = x.Maximum;
            lowTrackBar.Minimum = 0;
            lowTrackBar.Maximum = x.PointsPerRange;
            lowTrackBar.Value = 0;
            highTrackBar.Minimum = 0;
            highTrackBar.Maximum = x.PointsPerRange;
            highTrackBar.Value = highTrackBar.Maximum;
        }
        public void SetChartRange(PlotParameters x)
        {
            chart.Invoke(new setChartRangeDelegate(setChartRangeHelper), new Object[] { x }); 
        }

    }
}
