using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;

namespace ScanMaster
{
    public partial class FFTViewerWindow : Form
    {
        FFTViewer viewer;

        public FFTViewerWindow(FFTViewer viewer)
        {
            InitializeComponent();
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.AutoScroll = true;
            chart1.ChartAreas[0].CursorY.AutoScroll = true;
            this.viewer = viewer;
        }

        private delegate void PlotFFTDelegate(double[] t, double[] y);
        public void PlotFFT(double[] t, double[] y)
        {
            if (chart1.IsHandleCreated)
            {
                chart1.Invoke(new PlotFFTDelegate(plotFFTHelper), new Object[] { t, y });
            }
        }

        private void plotFFTHelper(double[] t, double[] y)
        {
            clear();
            plot(t, y);
        }

        private void plot(double[] t, double[] y)
        {
            for (int i = 0; i < t.Length; i++ )
            {
                chart1.Series[0].Points.AddXY(t[i], y[i]);
            }
        }

        private void clear()
        {
            chart1.Series[0].Points.Clear();
        }

        public int GetNumberOfPointsToDropFromUI()
        {
            int ptsToDrop;
            try
            {
                ptsToDrop = Int32.Parse(pointsToDropTextBox.Text);
            }
            catch
            {
                ptsToDrop = 0;
            }
            return Int32.Parse(pointsToDropTextBox.Text);
        }
    }
}
