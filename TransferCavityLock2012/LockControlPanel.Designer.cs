namespace TransferCavityLock2012
{
    partial class LockControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lockParams = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.setPointIncrementBox = new System.Windows.Forms.TextBox();
            this.GainTextbox = new System.Windows.Forms.TextBox();
            this.VoltageToLaserTextBox = new System.Windows.Forms.TextBox();
            this.setPointAdjustMinusButton = new System.Windows.Forms.Button();
            this.setPointAdjustPlusButton = new System.Windows.Forms.Button();
            this.LaserSetPointTextBox = new System.Windows.Forms.TextBox();
            this.lockEnableCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VoltageTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SlaveLaserIntensityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.slErrorResetButton = new System.Windows.Forms.Button();
            this.lockParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveLaserIntensityChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lockParams
            // 
            this.lockParams.Controls.Add(this.label10);
            this.lockParams.Controls.Add(this.setPointIncrementBox);
            this.lockParams.Controls.Add(this.GainTextbox);
            this.lockParams.Controls.Add(this.VoltageToLaserTextBox);
            this.lockParams.Controls.Add(this.setPointAdjustMinusButton);
            this.lockParams.Controls.Add(this.setPointAdjustPlusButton);
            this.lockParams.Controls.Add(this.LaserSetPointTextBox);
            this.lockParams.Controls.Add(this.lockEnableCheck);
            this.lockParams.Controls.Add(this.label4);
            this.lockParams.Controls.Add(this.label2);
            this.lockParams.Controls.Add(this.label3);
            this.lockParams.Controls.Add(this.VoltageTrackBar);
            this.lockParams.Location = new System.Drawing.Point(626, 3);
            this.lockParams.Name = "lockParams";
            this.lockParams.Size = new System.Drawing.Size(318, 186);
            this.lockParams.TabIndex = 13;
            this.lockParams.TabStop = false;
            this.lockParams.Text = "Lock Parameters";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Set Point Increment Size";
            // 
            // setPointIncrementBox
            // 
            this.setPointIncrementBox.Location = new System.Drawing.Point(168, 63);
            this.setPointIncrementBox.Name = "setPointIncrementBox";
            this.setPointIncrementBox.Size = new System.Drawing.Size(55, 20);
            this.setPointIncrementBox.TabIndex = 32;
            this.setPointIncrementBox.Text = "0.01";
            this.setPointIncrementBox.TextChanged += new System.EventHandler(this.setPointIncrementBox_TextChanged);
            // 
            // GainTextbox
            // 
            this.GainTextbox.Location = new System.Drawing.Point(167, 15);
            this.GainTextbox.Name = "GainTextbox";
            this.GainTextbox.Size = new System.Drawing.Size(81, 20);
            this.GainTextbox.TabIndex = 31;
            this.GainTextbox.Text = "0.5";
            this.GainTextbox.TextChanged += new System.EventHandler(this.GainChanged);
            // 
            // VoltageToLaserTextBox
            // 
            this.VoltageToLaserTextBox.Location = new System.Drawing.Point(167, 89);
            this.VoltageToLaserTextBox.Name = "VoltageToLaserTextBox";
            this.VoltageToLaserTextBox.Size = new System.Drawing.Size(100, 20);
            this.VoltageToLaserTextBox.TabIndex = 30;
            this.VoltageToLaserTextBox.Text = "0";
            this.VoltageToLaserTextBox.TextChanged += new System.EventHandler(this.VoltageToLaserChanged);
            // 
            // setPointAdjustMinusButton
            // 
            this.setPointAdjustMinusButton.Location = new System.Drawing.Point(124, 37);
            this.setPointAdjustMinusButton.Name = "setPointAdjustMinusButton";
            this.setPointAdjustMinusButton.Size = new System.Drawing.Size(37, 23);
            this.setPointAdjustMinusButton.TabIndex = 29;
            this.setPointAdjustMinusButton.Text = "-";
            this.setPointAdjustMinusButton.UseVisualStyleBackColor = true;
            this.setPointAdjustMinusButton.Click += new System.EventHandler(this.setPointAdjustMinusButton_Click);
            // 
            // setPointAdjustPlusButton
            // 
            this.setPointAdjustPlusButton.Location = new System.Drawing.Point(81, 37);
            this.setPointAdjustPlusButton.Name = "setPointAdjustPlusButton";
            this.setPointAdjustPlusButton.Size = new System.Drawing.Size(37, 23);
            this.setPointAdjustPlusButton.TabIndex = 28;
            this.setPointAdjustPlusButton.Text = "+";
            this.setPointAdjustPlusButton.UseVisualStyleBackColor = true;
            this.setPointAdjustPlusButton.Click += new System.EventHandler(this.setPointAdjustPlusButton_Click);
            // 
            // LaserSetPointTextBox
            // 
            this.LaserSetPointTextBox.AcceptsReturn = true;
            this.LaserSetPointTextBox.Location = new System.Drawing.Point(167, 39);
            this.LaserSetPointTextBox.Name = "LaserSetPointTextBox";
            this.LaserSetPointTextBox.Size = new System.Drawing.Size(57, 20);
            this.LaserSetPointTextBox.TabIndex = 27;
            this.LaserSetPointTextBox.Text = "0";
            // 
            // lockEnableCheck
            // 
            this.lockEnableCheck.AutoSize = true;
            this.lockEnableCheck.Location = new System.Drawing.Point(254, 17);
            this.lockEnableCheck.Name = "lockEnableCheck";
            this.lockEnableCheck.Size = new System.Drawing.Size(50, 17);
            this.lockEnableCheck.TabIndex = 9;
            this.lockEnableCheck.Text = "Lock";
            this.lockEnableCheck.UseVisualStyleBackColor = true;
            this.lockEnableCheck.CheckedChanged += new System.EventHandler(this.lockEnableCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Gain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Voltage sent to laser (V):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set Point (V):";
            // 
            // VoltageTrackBar
            // 
            this.VoltageTrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VoltageTrackBar.Location = new System.Drawing.Point(6, 135);
            this.VoltageTrackBar.Maximum = 1000;
            this.VoltageTrackBar.Name = "VoltageTrackBar";
            this.VoltageTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VoltageTrackBar.Size = new System.Drawing.Size(298, 45);
            this.VoltageTrackBar.TabIndex = 53;
            this.VoltageTrackBar.Value = 100;
            this.VoltageTrackBar.Scroll += new System.EventHandler(this.VoltageTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorChart);
            this.groupBox1.Controls.Add(this.SlaveLaserIntensityChart);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 310);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slave laser";
            // 
            // ErrorChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ErrorChart.ChartAreas.Add(chartArea1);
            this.ErrorChart.Location = new System.Drawing.Point(6, 166);
            this.ErrorChart.Name = "ErrorChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Name = "errorPlot";
            this.ErrorChart.Series.Add(series1);
            this.ErrorChart.Size = new System.Drawing.Size(604, 138);
            this.ErrorChart.TabIndex = 55;
            this.ErrorChart.Text = "chart2";
            // 
            // SlaveLaserIntensityChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SlaveLaserIntensityChart.ChartAreas.Add(chartArea2);
            this.SlaveLaserIntensityChart.Location = new System.Drawing.Point(6, 19);
            this.SlaveLaserIntensityChart.Name = "SlaveLaserIntensityChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Name = "slaveDataPlot";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "slaveFitPlot";
            this.SlaveLaserIntensityChart.Series.Add(series2);
            this.SlaveLaserIntensityChart.Series.Add(series3);
            this.SlaveLaserIntensityChart.Size = new System.Drawing.Size(604, 141);
            this.SlaveLaserIntensityChart.TabIndex = 54;
            this.SlaveLaserIntensityChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.slErrorResetButton);
            this.groupBox2.Location = new System.Drawing.Point(626, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 118);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error Signal Parameters";
            // 
            // slErrorResetButton
            // 
            this.slErrorResetButton.Location = new System.Drawing.Point(9, 19);
            this.slErrorResetButton.Name = "slErrorResetButton";
            this.slErrorResetButton.Size = new System.Drawing.Size(109, 23);
            this.slErrorResetButton.TabIndex = 29;
            this.slErrorResetButton.Text = "Reset Graph";
            this.slErrorResetButton.UseVisualStyleBackColor = true;
            this.slErrorResetButton.Click += new System.EventHandler(this.slErrorResetButton_Click);
            // 
            // LockControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lockParams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LockControlPanel";
            this.Size = new System.Drawing.Size(952, 316);
            this.lockParams.ResumeLayout(false);
            this.lockParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveLaserIntensityChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lockParams;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox setPointIncrementBox;
        private System.Windows.Forms.TextBox GainTextbox;
        private System.Windows.Forms.TextBox VoltageToLaserTextBox;
        private System.Windows.Forms.Button setPointAdjustMinusButton;
        private System.Windows.Forms.Button setPointAdjustPlusButton;
        private System.Windows.Forms.TextBox LaserSetPointTextBox;
        private System.Windows.Forms.CheckBox lockEnableCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button slErrorResetButton;
        public System.Windows.Forms.TrackBar VoltageTrackBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ErrorChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SlaveLaserIntensityChart;
    }
}
