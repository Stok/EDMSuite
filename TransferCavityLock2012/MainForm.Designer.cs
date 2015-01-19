namespace TransferCavityLock2012
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.voltageRampControl = new System.Windows.Forms.GroupBox();
            this.rampStopButton = new System.Windows.Forms.Button();
            this.rampStartButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfScanpointsTextBox = new System.Windows.Forms.TextBox();
            this.slaveLasersTab = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logCheckBox = new System.Windows.Forms.CheckBox();
            this.MasterSetPointTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masterLockEnableCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MasterGainTextBox = new System.Windows.Forms.TextBox();
            this.VToOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MasterFitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CavLockVoltageTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.CavityVoltageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MasterLaserIntensityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.voltageRampControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CavLockVoltageTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CavityVoltageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLaserIntensityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // voltageRampControl
            // 
            this.voltageRampControl.Controls.Add(this.rampStopButton);
            this.voltageRampControl.Controls.Add(this.rampStartButton);
            this.voltageRampControl.Controls.Add(this.label5);
            this.voltageRampControl.Controls.Add(this.NumberOfScanpointsTextBox);
            this.voltageRampControl.Location = new System.Drawing.Point(580, 12);
            this.voltageRampControl.Name = "voltageRampControl";
            this.voltageRampControl.Size = new System.Drawing.Size(355, 76);
            this.voltageRampControl.TabIndex = 2;
            this.voltageRampControl.TabStop = false;
            this.voltageRampControl.Text = "Analog Inputs";
            // 
            // rampStopButton
            // 
            this.rampStopButton.Location = new System.Drawing.Point(6, 46);
            this.rampStopButton.Name = "rampStopButton";
            this.rampStopButton.Size = new System.Drawing.Size(87, 23);
            this.rampStopButton.TabIndex = 6;
            this.rampStopButton.Text = "Stop reading";
            this.rampStopButton.UseVisualStyleBackColor = true;
            this.rampStopButton.Click += new System.EventHandler(this.rampStopButton_Click);
            // 
            // rampStartButton
            // 
            this.rampStartButton.Location = new System.Drawing.Point(6, 19);
            this.rampStartButton.Name = "rampStartButton";
            this.rampStartButton.Size = new System.Drawing.Size(87, 23);
            this.rampStartButton.TabIndex = 2;
            this.rampStartButton.Text = "Start reading";
            this.rampStartButton.UseVisualStyleBackColor = true;
            this.rampStartButton.Click += new System.EventHandler(this.rampStartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Number of points:";
            // 
            // NumberOfScanpointsTextBox
            // 
            this.NumberOfScanpointsTextBox.Location = new System.Drawing.Point(195, 21);
            this.NumberOfScanpointsTextBox.Name = "NumberOfScanpointsTextBox";
            this.NumberOfScanpointsTextBox.Size = new System.Drawing.Size(57, 20);
            this.NumberOfScanpointsTextBox.TabIndex = 22;
            // 
            // slaveLasersTab
            // 
            this.slaveLasersTab.Location = new System.Drawing.Point(12, 338);
            this.slaveLasersTab.Name = "slaveLasersTab";
            this.slaveLasersTab.SelectedIndex = 0;
            this.slaveLasersTab.Size = new System.Drawing.Size(952, 334);
            this.slaveLasersTab.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CavityVoltageChart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 158);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cavity Scan Voltage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MasterLaserIntensityChart);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 156);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reference laser";
            // 
            // logCheckBox
            // 
            this.logCheckBox.AutoSize = true;
            this.logCheckBox.Location = new System.Drawing.Point(586, 315);
            this.logCheckBox.Name = "logCheckBox";
            this.logCheckBox.Size = new System.Drawing.Size(124, 17);
            this.logCheckBox.TabIndex = 18;
            this.logCheckBox.Text = "Log laser parameters";
            this.logCheckBox.UseVisualStyleBackColor = true;
            this.logCheckBox.CheckedChanged += new System.EventHandler(this.logCheckBox_CheckedChanged);
            // 
            // MasterSetPointTextBox
            // 
            this.MasterSetPointTextBox.AcceptsReturn = true;
            this.MasterSetPointTextBox.Location = new System.Drawing.Point(658, 193);
            this.MasterSetPointTextBox.Name = "MasterSetPointTextBox";
            this.MasterSetPointTextBox.Size = new System.Drawing.Size(57, 20);
            this.MasterSetPointTextBox.TabIndex = 29;
            this.MasterSetPointTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Set Point (V):";
            // 
            // masterLockEnableCheck
            // 
            this.masterLockEnableCheck.AutoSize = true;
            this.masterLockEnableCheck.Location = new System.Drawing.Point(721, 195);
            this.masterLockEnableCheck.Name = "masterLockEnableCheck";
            this.masterLockEnableCheck.Size = new System.Drawing.Size(50, 17);
            this.masterLockEnableCheck.TabIndex = 35;
            this.masterLockEnableCheck.Text = "Lock";
            this.masterLockEnableCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Gain:";
            // 
            // MasterGainTextBox
            // 
            this.MasterGainTextBox.AcceptsReturn = true;
            this.MasterGainTextBox.Location = new System.Drawing.Point(658, 221);
            this.MasterGainTextBox.Name = "MasterGainTextBox";
            this.MasterGainTextBox.Size = new System.Drawing.Size(57, 20);
            this.MasterGainTextBox.TabIndex = 38;
            this.MasterGainTextBox.Text = "0";
            // 
            // VToOffsetTextBox
            // 
            this.VToOffsetTextBox.CausesValidation = false;
            this.VToOffsetTextBox.Location = new System.Drawing.Point(871, 221);
            this.VToOffsetTextBox.Name = "VToOffsetTextBox";
            this.VToOffsetTextBox.Size = new System.Drawing.Size(93, 20);
            this.VToOffsetTextBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Summed Voltage";
            // 
            // MasterFitTextBox
            // 
            this.MasterFitTextBox.CausesValidation = false;
            this.MasterFitTextBox.Location = new System.Drawing.Point(871, 193);
            this.MasterFitTextBox.Name = "MasterFitTextBox";
            this.MasterFitTextBox.ReadOnly = true;
            this.MasterFitTextBox.Size = new System.Drawing.Size(93, 20);
            this.MasterFitTextBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Voltage into Cavity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(773, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "at Ref Peak";
            // 
            // CavLockVoltageTrackBar
            // 
            this.CavLockVoltageTrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CavLockVoltageTrackBar.Location = new System.Drawing.Point(580, 263);
            this.CavLockVoltageTrackBar.Maximum = 1000;
            this.CavLockVoltageTrackBar.Minimum = -1000;
            this.CavLockVoltageTrackBar.Name = "CavLockVoltageTrackBar";
            this.CavLockVoltageTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CavLockVoltageTrackBar.Size = new System.Drawing.Size(384, 45);
            this.CavLockVoltageTrackBar.TabIndex = 52;
            this.CavLockVoltageTrackBar.Scroll += new System.EventHandler(this.CavLockVoltageTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(586, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Summed Voltage";
            // 
            // CavityVoltageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CavityVoltageChart.ChartAreas.Add(chartArea1);
            this.CavityVoltageChart.Location = new System.Drawing.Point(6, 19);
            this.CavityVoltageChart.Name = "CavityVoltageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "cavityVoltagePlot";
            this.CavityVoltageChart.Series.Add(series1);
            this.CavityVoltageChart.Size = new System.Drawing.Size(550, 133);
            this.CavityVoltageChart.TabIndex = 55;
            this.CavityVoltageChart.Text = "chart1";
            // 
            // MasterLaserIntensityChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MasterLaserIntensityChart.ChartAreas.Add(chartArea2);
            this.MasterLaserIntensityChart.Location = new System.Drawing.Point(6, 17);
            this.MasterLaserIntensityChart.Name = "MasterLaserIntensityChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Name = "masterDataPlot";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "masterFitPlot";
            this.MasterLaserIntensityChart.Series.Add(series2);
            this.MasterLaserIntensityChart.Series.Add(series3);
            this.MasterLaserIntensityChart.Size = new System.Drawing.Size(550, 133);
            this.MasterLaserIntensityChart.TabIndex = 56;
            this.MasterLaserIntensityChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 677);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CavLockVoltageTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MasterFitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VToOffsetTextBox);
            this.Controls.Add(this.MasterGainTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masterLockEnableCheck);
            this.Controls.Add(this.MasterSetPointTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.slaveLasersTab);
            this.Controls.Add(this.voltageRampControl);
            this.Name = "MainForm";
            this.Text = "Transfer Cavity Lock 2012";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.voltageRampControl.ResumeLayout(false);
            this.voltageRampControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CavLockVoltageTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CavityVoltageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLaserIntensityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox voltageRampControl;
        private System.Windows.Forms.Button rampStartButton;
        private System.Windows.Forms.Button rampStopButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberOfScanpointsTextBox;
        private System.Windows.Forms.TabControl slaveLasersTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox logCheckBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox masterLockEnableCheck;
        public System.Windows.Forms.TextBox MasterSetPointTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MasterGainTextBox;
        public System.Windows.Forms.TextBox VToOffsetTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox MasterFitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TrackBar CavLockVoltageTrackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart CavityVoltageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MasterLaserIntensityChart;
    }
}

