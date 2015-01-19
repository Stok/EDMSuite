using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//using NationalInstruments.UI.WindowsForms;
//using NationalInstruments.UI;

namespace TransferCavityLock2012
{
    public partial class LockControlPanel : UserControl
    {
        private string name;
        private double upperVoltageLimit = 10;
        private double lowerVoltageLimit = 0;

        public int Count = 0; 

        public Controller controller;

        public LockControlPanel(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        public LockControlPanel(string name, double lowerVoltageLimit, double upperVoltageLimit)
        {
            this.name = name;
            this.upperVoltageLimit = upperVoltageLimit;
            this.lowerVoltageLimit = lowerVoltageLimit; 
            InitializeComponent();
        }


        #region ThreadSafe wrappers

        public void SetCheckBox(CheckBox box, bool state)
        {
            box.Invoke(new SetCheckDelegate(SetCheckHelper), new object[] { box, state });
        }
        private delegate void SetCheckDelegate(CheckBox box, bool state);
        private void SetCheckHelper(CheckBox box, bool state)
        {
            box.Checked = state;
        }


        public void SetTextBox(TextBox box, string text)
        {
            box.Invoke(new SetTextDelegate(SetTextHelper), new object[] { box, text });
        }
        private delegate void SetTextDelegate(TextBox box, string text);
        private void SetTextHelper(TextBox box, string text)
        {
            box.Text = text;
        }

        public void EnableControl(Control control, bool enabled)
        {
            control.Invoke(new EnableControlDelegate(EnableControlHelper), new object[] { control, enabled });
        }
        private delegate void EnableControlDelegate(Control control, bool enabled);
        private void EnableControlHelper(Control control, bool enabled)
        {
            control.Enabled = enabled;
        }

        private delegate void plotSeriesDelegate(Series plot,
           double[] x, double[] y);
        private void plotSeriesHelper(Series plot,
            double[] x, double[] y)
        {
            lock (this)
            {
                plot.Points.Clear();
                for (int i = 0; i < x.Length; i++)
                {
                    plot.Points.AddXY(x[i], y[i]);
                }
                plot.Sort(PointSortOrder.Ascending, "X");
            }
        }
        private void seriesPlot(Chart figure, Series plot, double[] x, double[] y)
        {
            figure.Invoke(new plotSeriesDelegate(plotSeriesHelper), new object[] { plot, x, y });
        }



        private delegate void seriesAppendDelegate(Series plot, double[] x, double[] y);

        private void seriesAppendHelper(Series plot, double[] x, double[] y)
        {
            lock (this)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    plot.Points.AddXY(x[i], y[i]);
                }
                plot.Sort(PointSortOrder.Ascending, "X");
            }
        }
        private void plotXYAppend(Chart figure, Series plot, double[] x, double[] y)
        {
            figure.Invoke(new seriesAppendDelegate(seriesAppendHelper), new Object[] { x, y });
        }



        private delegate void ClearDataDelegate(Series plot);
        private void clearSeries(Chart graph, Series plot)
        {
            graph.Invoke(new ClearDataDelegate(clearSeriesHelper));
        }
        private void clearSeriesHelper(Series plot)
        {
            plot.Points.Clear();
        }

        #endregion

        #region Events
        private void setPointAdjustPlusButton_Click(object sender, EventArgs e)
        {
            lock (controller.tweakLock)
            {
                controller.AddSetPointIncrement(name);
            }
        }

        private void setPointAdjustMinusButton_Click(object sender, EventArgs e)
        {
            lock (controller.tweakLock)
            {
                controller.AddSetPointDecrement(name);
            }
        }


        private void lockEnableCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lockEnableCheck.CheckState == CheckState.Checked)
            {
                controller.EngageLock(name);
            }
            if (lockEnableCheck.CheckState == CheckState.Unchecked)
            {
                controller.DisengageLock(name);
            }

        }


        private void VoltageToLaserChanged(object sender, EventArgs e)
        {
            try
            {
                controller.VoltageToLaserChanged(name, Double.Parse(VoltageToLaserTextBox.Text));
            }
            catch (Exception)
            {
            }
        }

        private void GainChanged(object sender, EventArgs e)
        {
            try
            {
                controller.GainChanged(name, Double.Parse(GainTextbox.Text));
            }
            catch (Exception)
            {

            }
        }
        private void setPointIncrementBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                controller.SetPointIncrementSize(name, Double.Parse(setPointIncrementBox.Text));
            }
            catch { }
        }


        private void slErrorResetButton_Click(object sender, EventArgs e)
        {
            ClearErrorGraph();
            Count = 0; 
        }

        private void VoltageTrackBar_Scroll(object sender, EventArgs e)
        {
            
            SetLaserVoltage((((double)VoltageTrackBar.Value) / 1000)*(upperVoltageLimit-lowerVoltageLimit));
        }

        #endregion

        #region Setting and getting parameter values from textboxes

        public void SetLaserVoltage(double value)
        {
            SetTextBox(VoltageToLaserTextBox, Convert.ToString(value));
        }

        public void SetGain(double value)
        {
            SetTextBox(GainTextbox, Convert.ToString(value));
        }
        public double GetGain()
        {
            return Double.Parse(GainTextbox.Text);
        }

        public void SetSetPointIncrementSize(double value)
        {
            SetTextBox(setPointIncrementBox, Convert.ToString(value));
        }

        public double GetLaserSetPoint()
        {
            return Double.Parse(LaserSetPointTextBox.Text);
        }
        public void SetLaserSetPoint(double value)
        {
            SetTextBox(LaserSetPointTextBox, Convert.ToString(value));
        }

        public void DisplayData(double[] cavityData, double[] slaveData)
        {
            //seriesPlot(SlaveLaserIntensityScatterGraph,
                //SlaveDataPlot, cavityData, slaveData);
            seriesPlot(SlaveLaserIntensityChart, SlaveLaserIntensityChart.Series.FindByName("slaveDataPlot"), cavityData, slaveData);
        }
        public void DisplayFit(double[] cavityData, double[] slaveData)
        {
            seriesPlot(SlaveLaserIntensityChart, SlaveLaserIntensityChart.Series.FindByName("slaveFitPlot"), cavityData, slaveData);
        }

         public void AppendToErrorGraph(double[] x, double[] y)
        {
            plotXYAppend(ErrorChart, ErrorChart.Series.FindByName("errorPlot"), x, y);
        }

         public void ClearErrorGraph()
         {
             clearSeries(ErrorChart, SlaveLaserIntensityChart.Series.FindByName("slaveFitPlot"));
         }

        
        #endregion

        #region UI state control
        public void UpdateUIState(SlaveLaser.LaserState state)
        {
            switch (state)
            {
                case SlaveLaser.LaserState.FREE:
                    lockEnableCheck.Enabled = true;
                    VoltageToLaserTextBox.Enabled = true;    
                    LaserSetPointTextBox.Enabled = false;
                    GainTextbox.Enabled = true;
                    //lockedLED.Value = false;
                    VoltageTrackBar.Enabled = true;
                    break;

                case SlaveLaser.LaserState.LOCKING:
                    VoltageToLaserTextBox.Enabled = false;
                    GainTextbox.Enabled = false;
                    //lockedLED.Value = false;
                    VoltageTrackBar.Enabled = false;
                    break;

                case SlaveLaser.LaserState.LOCKED:
                    //lockedLED.Value = true;
                    break;

            }
        }

        #endregion




   
     
    }
}
