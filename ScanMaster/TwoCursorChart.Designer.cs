namespace ScanMaster.GUI
{
    partial class TwoCursorChart
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lowTrackBar = new System.Windows.Forms.TrackBar();
            this.highTrackBar = new System.Windows.Forms.TrackBar();
            this.CursorsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTrackBar)).BeginInit();
            this.CursorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart.Location = new System.Drawing.Point(0, 123);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "onPlot";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Name = "offPlot";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "onAveragePlot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "offAveragePlot";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Name = "fitPlot";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Green;
            series6.Name = "lowCursor";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Name = "highCursor";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Series.Add(series7);
            this.chart.Size = new System.Drawing.Size(376, 299);
            this.chart.TabIndex = 61;
            this.chart.Text = "chart1";
            // 
            // lowTrackBar
            // 
            this.lowTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.lowTrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lowTrackBar.Location = new System.Drawing.Point(3, 16);
            this.lowTrackBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lowTrackBar.Name = "lowTrackBar";
            this.lowTrackBar.Size = new System.Drawing.Size(370, 45);
            this.lowTrackBar.TabIndex = 62;
            this.lowTrackBar.ValueChanged += new System.EventHandler(this.lowTrackBar_ValueChanged);
            // 
            // highTrackBar
            // 
            this.highTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.highTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.highTrackBar.Location = new System.Drawing.Point(3, 69);
            this.highTrackBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.highTrackBar.Name = "highTrackBar";
            this.highTrackBar.Size = new System.Drawing.Size(370, 45);
            this.highTrackBar.TabIndex = 63;
            this.highTrackBar.Value = 10;
            this.highTrackBar.ValueChanged += new System.EventHandler(this.highTrackBar_ValueChanged);
            // 
            // CursorsGroupBox
            // 
            this.CursorsGroupBox.Controls.Add(this.lowTrackBar);
            this.CursorsGroupBox.Controls.Add(this.highTrackBar);
            this.CursorsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CursorsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CursorsGroupBox.Name = "CursorsGroupBox";
            this.CursorsGroupBox.Size = new System.Drawing.Size(376, 117);
            this.CursorsGroupBox.TabIndex = 64;
            this.CursorsGroupBox.TabStop = false;
            this.CursorsGroupBox.Text = "Cursors";
            // 
            // TwoCursorChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.chart);
            this.Controls.Add(this.CursorsGroupBox);
            this.Name = "TwoCursorChart";
            this.Size = new System.Drawing.Size(376, 422);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTrackBar)).EndInit();
            this.CursorsGroupBox.ResumeLayout(false);
            this.CursorsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TrackBar lowTrackBar;
        private System.Windows.Forms.TrackBar highTrackBar;
        private System.Windows.Forms.GroupBox CursorsGroupBox;
    }
}
