namespace ParityHardwareControl
{
    partial class ControlWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NIScopeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.NIScopeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // NIScopeChart
            // 
            chartArea1.Name = "niScopeChartArea";
            this.NIScopeChart.ChartAreas.Add(chartArea1);
            this.NIScopeChart.Location = new System.Drawing.Point(12, 12);
            this.NIScopeChart.Name = "NIScopeChart";
            series1.ChartArea = "niScopeChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "ch1";
            series2.ChartArea = "niScopeChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Name = "ch2";
            this.NIScopeChart.Series.Add(series1);
            this.NIScopeChart.Series.Add(series2);
            this.NIScopeChart.Size = new System.Drawing.Size(521, 385);
            this.NIScopeChart.TabIndex = 0;
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 409);
            this.Controls.Add(this.NIScopeChart);
            this.Name = "ControlWindow";
            this.Text = "Parity Hardware Control";
            ((System.ComponentModel.ISupportInitialize)(this.NIScopeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart NIScopeChart;
    }
}