using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace SharedCode.DataVisualization
{
    public partial class WinDVChartHelper : UserControl
    {
        private string name;
        //System.Windows.Forms.DataVisualization.Charting.Cursor cursor;
            
        public WinDVChartHelper()
        {
            InitializeComponent();
        }

        public WinDVChartHelper(string name)
        {
            InitializeComponent();
            this.name = name;
            //cursor = new System.Windows.Forms.DataVisualization.Charting.Cursor();
            //cursor.IsUserEnabled = true;
            //cursor.IsUserSelectionEnabled = true;
        }
        
        delegate void ManipulatePointDelegate(string seriesName, double x, double y);
        delegate void ManipulatePointsDelegate(string seriesName, double[] x, double[] y);

        public void AddPoint(string seriesName, double x, double y)
        {
            Invoke(new ManipulatePointDelegate(addPoint), new object[] {seriesName, x, y });
        }
        public void AddPoints(string seriesName, double[] x, double[] y)
        {
            Invoke(new ManipulatePointsDelegate(addPoints), new object[] { seriesName, x, y });
        }
        public void RemovePoint(string seriesName, double x, double y)
        {
            Invoke(new ManipulatePointDelegate(removePoint), new object[] { seriesName, x, y });
        }

        private void addPoint(string seriesName, double x, double y)
        {
            Chart.Series.FindByName(seriesName).Points.AddXY(x, y);
            Chart.Series.FindByName(seriesName).Sort(PointSortOrder.Ascending, "X");
            
        }
        private void addPoints(string seriesName, double[] x, double[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Chart.Series.FindByName(seriesName).Points.AddXY(x[i], y[i]);
            }
            Chart.Series.FindByName(seriesName).Sort(PointSortOrder.Ascending, "X");

        }
        private void removePoint(string seriesName, double x, double y)
        {
            DataPoint point = new DataPoint(x, y);
            int index = Chart.Series.FindByName(seriesName).Points.IndexOf(point);
            Chart.Series.FindByName(seriesName).Points[index].Dispose();
            Chart.Series.FindByName(seriesName).Sort(PointSortOrder.Ascending, "X");
        }

        public void ReplacePoint(string seriesName, double x, double oldY, double newY)
        {
            RemovePoint(seriesName, x, oldY);
            AddPoint(seriesName, x, newY);
        }

        public void AddSeries(string name, string xAxisType)
        {
            Chart.Series.Add(new Series(name));
            Chart.Series.FindByName(name).ChartType = SeriesChartType.FastPoint;
            if (xAxisType == "time")
            {
                Chart.Series.FindByName(name).XValueType = ChartValueType.Double;
            }
            else
            {
                Chart.Series.FindByName(name).XValueType = ChartValueType.Double;
            }
            //cursor = new System.Windows.Forms.DataVisualization.Charting.Cursor();
            //cursor.IsUserEnabled = true;
            //cursor.IsUserSelectionEnabled = true;
        }
        private void clearSeries(int seriesIndex)
        {
            object clearLock = new object();
            lock(clearLock)
            {
                Chart.Series[seriesIndex].Points.Clear();
            }
        }
        delegate void clearSeriesDelegate(int i);
        public void ClearSeries(int seriesIndex)
        {
            Invoke(new clearSeriesDelegate(clearSeries), new object[] { seriesIndex });
        }

        public void ClearPlot()
        {
            for (int i = 0; i < Chart.Series.Count; i++)
            {
                ClearSeries(i);
            }
        }
    }
}
