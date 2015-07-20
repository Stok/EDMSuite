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
        private PlotParameters xRange, yRange;
        
        public TwoCursorChart()
        {
            InitializeComponent();
            yRange = new PlotParameters(0, 1); //set to avoid crashes that happen when plot range = 0
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
            double newValue =  (lowTrackBar.Value / (double)xRange.PointsPerRange) * xRange.GetInterval() + xRange.Minimum;
            return newValue;
        }
        public double GetHighCursorValue()
        {
            return (double)chart.Invoke(new getValueDelegate(getHighCursorValueHelper));
        }
        private double getHighCursorValueHelper()
        {
            return (highTrackBar.Value / (double)xRange.PointsPerRange) * xRange.GetInterval() + xRange.Minimum;
        }
        #endregion

        private delegate void setChartRangeDelegate(PlotParameters x);
        private void setChartAxesAndGateHelper(PlotParameters x)
        {
            setChartAxesHelper(x);
            setChartGateHelper(x);
        }
        private void setChartAxesHelper(PlotParameters x)
        {
            xRange = x;
            chart.ChartAreas[0].AxisX.Minimum = x.Minimum;
            chart.ChartAreas[0].AxisX.Maximum = x.Maximum;
        }
        private void setChartGateHelper(PlotParameters x)
        {
            lowTrackBar.Minimum = 0;
            lowTrackBar.Maximum = x.PointsPerRange;
            lowTrackBar.Value = 0;
            highTrackBar.Minimum = 0;
            highTrackBar.Maximum = x.PointsPerRange;
            highTrackBar.Value = highTrackBar.Maximum;
        }
        public void SetChartAxesAndGate(PlotParameters x)
        {
            chart.Invoke(new setChartRangeDelegate(setChartAxesAndGateHelper), new Object[] { x }); 
        }
        public void SetChartAxes(PlotParameters x)
        {
            chart.Invoke(new setChartRangeDelegate(setChartAxesHelper), new Object[] { x });
        }
        public void SetChartGate(PlotParameters x)
        {
            chart.Invoke(new setChartRangeDelegate(setChartGateHelper), new Object[] { x });
        }

        #region resetting axes
        
        public void ResetYAxesScale()
        {
            PlotParameters y = getExtremeYValueInPlot();
            chart.ChartAreas[0].AxisY.Minimum = Math.Round(y.Minimum - y.GetInterval() / 50.0, 2);
            chart.ChartAreas[0].AxisY.Maximum = Math.Round(y.Maximum + y.GetInterval() / 50.0, 2);
            yRange = y;
        }
        private PlotParameters getExtremeYValueInPlot()
        {
            double? maxOfSeries, minOfSeries, maxOfChart = null, minOfChart = null;          
            for (int i = 0; i < 5; i++)
            {
                if (chart.Series[i].Points.Count > 1)
                {
                    maxOfSeries = chart.Series[i].Points.FindMaxByValue("Y1").YValues[0];
                    minOfSeries = chart.Series[i].Points.FindMinByValue("Y1").YValues[0];
                }
                else { maxOfSeries = null; minOfSeries = null; }
                if (maxOfSeries > maxOfChart || maxOfChart == null)
                {
                    maxOfChart = maxOfSeries;
                }
                if (minOfSeries < minOfChart || minOfChart == null)
                {
                    minOfChart = minOfSeries;
                }
            }
            return new PlotParameters((double)minOfChart, (double)maxOfChart);
        }
        
        #endregion

        #region Plotting and clearing points

        private delegate void ClearSeriesDelegate(Series s);
        public void ClearSeries(Series s)
        {
            if (chart.IsHandleCreated)
            {
                chart.Invoke(new ClearSeriesDelegate(clearSeriesHelper), new Object[] { s });
            }
        }
        private void clearSeriesHelper(Series s)
        {
            if (chart.IsHandleCreated)
            {
                s.Points.Clear();
            }
        }
        
        public void ClearChart()
        {
            for (int i = 0; i < 5; i++)
            {
                ClearSeries(chart.Series[i]);
            }
        }

        private delegate void seriesAppendDelegate(Series s, double[] x, double[] y);
        public void PlotXYAppend(Series s, double[] x, double[] y)
        {
            if (chart.IsHandleCreated)
            {
                chart.Invoke(new seriesAppendDelegate(seriesAppendHelper), new Object[] { s, x, y });
            }
        }
        private void seriesAppendHelper(Series s, double[] x, double[] y)
        {
            lock (this)
            {
                if(chart.Series[0].Points.Count > 1) //Prevent plot range = 0 bugs
                {
                    ResetYAxesScale();
                }
                for (int i = 0; i < x.Length; i++)
                {
                    s.Points.AddXY(x[i], y[i]);
                }
                s.Sort(PointSortOrder.Ascending, "X");
            }
        }

        public void PlotXY(Series plot, double[] x, double[] y)
        {
            this.ClearSeries(plot);
            this.PlotXYAppend(plot, x, y);
        }

        private delegate void PlotYDelegate(Series s, double start, double inc, double[] yData);
        public void PlotY(Series p, double start, double inc, double[] ydata)
        {
            chart.Invoke(new PlotYDelegate(plotYHelper), new Object[] { p, start, inc, ydata });
        }
        private void plotYHelper(Series series, double start, double inc, double[] ydata)
        {
            double[] xValues = new double[ydata.Length];
            for (int i = 0; i < xValues.Length; i++)
            {
                xValues[i] = start + inc * i;
            }
            chart.ChartAreas[0].AxisX.Minimum = start;
            chart.ChartAreas[0].AxisX.Maximum = xValues[xValues.Length - 1];
            PlotXY(series, xValues, ydata);
            if (chart.Series[0].Points.Count > 1) //Prevent plot range = 0 bugs
            {
                ResetYAxesScale();
            }
        }

        #endregion
    }
}
