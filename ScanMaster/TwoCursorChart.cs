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
        //private PlotParameters xRange, yRange;
        int numberOfPoints;
        double Xmin, Xmax;
        public TwoCursorChart()
        {
            InitializeComponent();
        }
        private delegate void setChartRangeDelegate(PlotParameters x, bool resetCursorsQ);
        public void InitializeTwoCursorChart(PlotParameters x, bool resetCursorsQ)
        {
            chart.Invoke(new setChartRangeDelegate(initialize), new Object[] { x, resetCursorsQ });
        }
        private void initialize(PlotParameters p, bool resetCursorsQ)
        {
            this.numberOfPoints = p.PointsPerRange;
            this.Xmin = p.Minimum;
            this.Xmax = p.Maximum;
            chart.ChartAreas[0].AxisX.Minimum = Xmin;
            chart.ChartAreas[0].AxisX.Maximum = Xmax;
            lowTrackBar.Minimum = (int)Math.Round(Xmin);
            lowTrackBar.Maximum = (int)Math.Round(Xmax);
            highTrackBar.Minimum = (int)Math.Round(Xmin);
            highTrackBar.Maximum = (int)Math.Round(Xmax);
            if (resetCursorsQ)
            {
                lowTrackBar.Value = 0;
                highTrackBar.Value = highTrackBar.Maximum;
            }
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
                chart.ChartAreas[0].RecalculateAxesScale();
                this.GetSeriesByName("lowCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum);
                this.GetSeriesByName("lowCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Maximum);
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
                chart.ChartAreas[0].RecalculateAxesScale();
                this.GetSeriesByName("highCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum);
                this.GetSeriesByName("highCursor").Points.AddXY(x, chart.ChartAreas[0].AxisY.Maximum);
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
            return lowTrackBar.Value;
        }
        public double GetHighCursorValue()
        {
            return (double)chart.Invoke(new getValueDelegate(getHighCursorValueHelper));
        }
        private double getHighCursorValueHelper()
        {
            return highTrackBar.Value;
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
                double[] xToPlot, yToPlot;
                if (x.Length < 200)
                {
                    xToPlot = x;
                    yToPlot = y;
                }
                else
                {
                    xToPlot = new double[200];
                    yToPlot = new double[200];
                    int interval =(int)Math.Floor((double)x.Length / 200.0);
                    for(int i = 0; i < 200; i++)
                    {
                        xToPlot[i] = x[i * interval];
                        yToPlot[i] = y[i * interval];
                    }
                }
                for (int i = 0; i < xToPlot.Length; i++)
                {
                    s.Points.AddXY(xToPlot[i], yToPlot[i]);
                }
                s.Sort(PointSortOrder.Ascending, "X");
                chart.ChartAreas[0].RecalculateAxesScale();
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
                PlotXY(series, xValues, ydata);
        }

        #endregion
    }
}
