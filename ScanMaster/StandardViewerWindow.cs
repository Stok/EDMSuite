using System;
using System.Collections;
using System.Windows.Forms;


using System.Windows.Forms.DataVisualization.Charting;

using Data;

namespace ScanMaster.GUI
{

	/// <summary>
	/// </summary>
	public class StandardViewerWindow : System.Windows.Forms.Form
	{

		// this windows associated Viewer
		private StandardViewer viewer;
        private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox tofFitFunctionCombo;
		private System.Windows.Forms.Label label2;
		public ComboBox tofFitModeCombo;
		public System.Windows.Forms.ComboBox spectrumFitFunctionCombo;
		public ComboBox spectrumFitModeCombo;
		public System.Windows.Forms.Label tofFitResultsLabel;
        public System.Windows.Forms.Label spectrumFitResultsLabel;
		private Button updateTOFFitButton;
        private Button updateSpectrumFitButton;
        public ComboBox tofFitDataSelectCombo;
        private SplitContainer splitContainer1;
        private StatusBar statusBar1;
        private Label label3;
        private Button updateNoiseResultsbutton;
        public Label noiseResultsLabel;
        private SplitContainer splitContainer2;
        private StatusBar statusBar2;
        private Button defaultGateButton;

        private Chart analog2Graph;
        private Chart differenceGraph;

        private Chart tofGraph;
        private Chart pmtGraph;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private TextBox endTOFCursorPositionTextBox;
        private TextBox startTOFCursorPositionTextBox;
        private Button updateTOFCursorsButton;
        private Label label5;
        private Label label4;
        private TextBox endPMTCursorPositionTextBox;
        private TextBox startPMTCursorPositionTextBox;
        private Button updatePMTCursorsButton;
        private Chart analog1Graph;

		public StandardViewerWindow(StandardViewer viewer)
		{
			this.viewer = viewer;
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardViewerWindow));
            this.tofFitModeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tofFitFunctionCombo = new System.Windows.Forms.ComboBox();
            this.spectrumFitFunctionCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spectrumFitModeCombo = new System.Windows.Forms.ComboBox();
            this.tofFitResultsLabel = new System.Windows.Forms.Label();
            this.spectrumFitResultsLabel = new System.Windows.Forms.Label();
            this.updateTOFFitButton = new System.Windows.Forms.Button();
            this.updateSpectrumFitButton = new System.Windows.Forms.Button();
            this.tofFitDataSelectCombo = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.statusBar2 = new System.Windows.Forms.StatusBar();
            this.defaultGateButton = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label3 = new System.Windows.Forms.Label();
            this.updateNoiseResultsbutton = new System.Windows.Forms.Button();
            this.noiseResultsLabel = new System.Windows.Forms.Label();
            this.analog1Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analog2Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.differenceGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tofGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pmtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endTOFCursorPositionTextBox = new System.Windows.Forms.TextBox();
            this.startTOFCursorPositionTextBox = new System.Windows.Forms.TextBox();
            this.updateTOFCursorsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.endPMTCursorPositionTextBox = new System.Windows.Forms.TextBox();
            this.startPMTCursorPositionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updatePMTCursorsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analog1Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog2Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tofGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmtGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tofFitModeCombo
            // 
            this.tofFitModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tofFitModeCombo.Items.AddRange(new object[] {
            "off",
            "average"});
            this.tofFitModeCombo.Location = new System.Drawing.Point(64, 37);
            this.tofFitModeCombo.Name = "tofFitModeCombo";
            this.tofFitModeCombo.Size = new System.Drawing.Size(72, 21);
            this.tofFitModeCombo.TabIndex = 17;
            this.tofFitModeCombo.SelectedIndexChanged += new System.EventHandler(this.tofFitModeCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fit TOF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tofFitFunctionCombo
            // 
            this.tofFitFunctionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tofFitFunctionCombo.Location = new System.Drawing.Point(142, 37);
            this.tofFitFunctionCombo.Name = "tofFitFunctionCombo";
            this.tofFitFunctionCombo.Size = new System.Drawing.Size(88, 21);
            this.tofFitFunctionCombo.TabIndex = 19;
            this.tofFitFunctionCombo.SelectedIndexChanged += new System.EventHandler(this.tofFitFunctionCombo_SelectedIndexChanged);
            // 
            // spectrumFitFunctionCombo
            // 
            this.spectrumFitFunctionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spectrumFitFunctionCombo.Location = new System.Drawing.Point(636, 34);
            this.spectrumFitFunctionCombo.Name = "spectrumFitFunctionCombo";
            this.spectrumFitFunctionCombo.Size = new System.Drawing.Size(88, 21);
            this.spectrumFitFunctionCombo.TabIndex = 22;
            this.spectrumFitFunctionCombo.SelectedIndexChanged += new System.EventHandler(this.spectrumFitFunctionCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(555, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fit spectrum:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spectrumFitModeCombo
            // 
            this.spectrumFitModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spectrumFitModeCombo.Items.AddRange(new object[] {
            "off",
            "average",
            "shot"});
            this.spectrumFitModeCombo.Location = new System.Drawing.Point(558, 34);
            this.spectrumFitModeCombo.Name = "spectrumFitModeCombo";
            this.spectrumFitModeCombo.Size = new System.Drawing.Size(72, 21);
            this.spectrumFitModeCombo.TabIndex = 20;
            this.spectrumFitModeCombo.SelectedIndexChanged += new System.EventHandler(this.spectrumFitModeCombo_SelectedIndexChanged);
            // 
            // tofFitResultsLabel
            // 
            this.tofFitResultsLabel.ForeColor = System.Drawing.Color.Blue;
            this.tofFitResultsLabel.Location = new System.Drawing.Point(260, 34);
            this.tofFitResultsLabel.Name = "tofFitResultsLabel";
            this.tofFitResultsLabel.Size = new System.Drawing.Size(100, 24);
            this.tofFitResultsLabel.TabIndex = 23;
            this.tofFitResultsLabel.Text = "...";
            this.tofFitResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spectrumFitResultsLabel
            // 
            this.spectrumFitResultsLabel.ForeColor = System.Drawing.Color.Blue;
            this.spectrumFitResultsLabel.Location = new System.Drawing.Point(752, 33);
            this.spectrumFitResultsLabel.Name = "spectrumFitResultsLabel";
            this.spectrumFitResultsLabel.Size = new System.Drawing.Size(210, 24);
            this.spectrumFitResultsLabel.TabIndex = 24;
            this.spectrumFitResultsLabel.Text = "...";
            this.spectrumFitResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTOFFitButton
            // 
            this.updateTOFFitButton.Location = new System.Drawing.Point(236, 35);
            this.updateTOFFitButton.Name = "updateTOFFitButton";
            this.updateTOFFitButton.Size = new System.Drawing.Size(18, 23);
            this.updateTOFFitButton.TabIndex = 25;
            this.updateTOFFitButton.Text = ">";
            this.updateTOFFitButton.UseVisualStyleBackColor = true;
            this.updateTOFFitButton.Click += new System.EventHandler(this.updateTOFFitButton_Click);
            // 
            // updateSpectrumFitButton
            // 
            this.updateSpectrumFitButton.Location = new System.Drawing.Point(728, 34);
            this.updateSpectrumFitButton.Name = "updateSpectrumFitButton";
            this.updateSpectrumFitButton.Size = new System.Drawing.Size(18, 23);
            this.updateSpectrumFitButton.TabIndex = 26;
            this.updateSpectrumFitButton.Text = ">";
            this.updateSpectrumFitButton.UseVisualStyleBackColor = true;
            this.updateSpectrumFitButton.Click += new System.EventHandler(this.updateSpectrumFitButton_Click);
            // 
            // tofFitDataSelectCombo
            // 
            this.tofFitDataSelectCombo.FormattingEnabled = true;
            this.tofFitDataSelectCombo.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.tofFitDataSelectCombo.Location = new System.Drawing.Point(8, 37);
            this.tofFitDataSelectCombo.Name = "tofFitDataSelectCombo";
            this.tofFitDataSelectCombo.Size = new System.Drawing.Size(50, 21);
            this.tofFitDataSelectCombo.TabIndex = 27;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 726);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusBar1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 23);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 30;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.statusBar2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.defaultGateButton);
            this.splitContainer2.Size = new System.Drawing.Size(427, 23);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(271, 23);
            this.statusBar2.SizingGrip = false;
            this.statusBar2.TabIndex = 32;
            this.statusBar2.Text = "Ready";
            // 
            // defaultGateButton
            // 
            this.defaultGateButton.Location = new System.Drawing.Point(3, 0);
            this.defaultGateButton.Name = "defaultGateButton";
            this.defaultGateButton.Size = new System.Drawing.Size(120, 23);
            this.defaultGateButton.TabIndex = 26;
            this.defaultGateButton.Text = "Default Gate";
            this.defaultGateButton.UseVisualStyleBackColor = true;
            this.defaultGateButton.Click += new System.EventHandler(this.defaultGateButton_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 0);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(690, 23);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 14;
            this.statusBar1.Text = "Ready";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(382, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "Factor over shot noise:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateNoiseResultsbutton
            // 
            this.updateNoiseResultsbutton.Location = new System.Drawing.Point(385, 31);
            this.updateNoiseResultsbutton.Name = "updateNoiseResultsbutton";
            this.updateNoiseResultsbutton.Size = new System.Drawing.Size(18, 23);
            this.updateNoiseResultsbutton.TabIndex = 32;
            this.updateNoiseResultsbutton.Text = ">";
            this.updateNoiseResultsbutton.UseVisualStyleBackColor = true;
            this.updateNoiseResultsbutton.Click += new System.EventHandler(this.updateNoiseResultsbutton_Click);
            // 
            // noiseResultsLabel
            // 
            this.noiseResultsLabel.ForeColor = System.Drawing.Color.Blue;
            this.noiseResultsLabel.Location = new System.Drawing.Point(409, 32);
            this.noiseResultsLabel.Name = "noiseResultsLabel";
            this.noiseResultsLabel.Size = new System.Drawing.Size(143, 24);
            this.noiseResultsLabel.TabIndex = 33;
            this.noiseResultsLabel.Text = "...";
            this.noiseResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // analog1Graph
            // 
            this.analog1Graph.BackColor = System.Drawing.Color.Transparent;
            this.analog1Graph.BorderlineColor = System.Drawing.Color.Black;
            this.analog1Graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.analog1Graph.ChartAreas.Add(chartArea1);
            this.analog1Graph.Location = new System.Drawing.Point(10, 19);
            this.analog1Graph.Name = "analog1Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "analog1Plot";
            this.analog1Graph.Series.Add(series1);
            this.analog1Graph.Size = new System.Drawing.Size(582, 133);
            this.analog1Graph.TabIndex = 57;
            this.analog1Graph.Text = "chart1";
            // 
            // analog2Graph
            // 
            this.analog2Graph.BackColor = System.Drawing.Color.Transparent;
            this.analog2Graph.BorderlineColor = System.Drawing.Color.Black;
            this.analog2Graph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.analog2Graph.ChartAreas.Add(chartArea2);
            this.analog2Graph.Location = new System.Drawing.Point(10, 162);
            this.analog2Graph.Name = "analog2Graph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Name = "analog2Plot";
            this.analog2Graph.Series.Add(series2);
            this.analog2Graph.Size = new System.Drawing.Size(582, 133);
            this.analog2Graph.TabIndex = 58;
            this.analog2Graph.Text = "chart1";
            // 
            // differenceGraph
            // 
            this.differenceGraph.BackColor = System.Drawing.Color.Transparent;
            this.differenceGraph.BorderlineColor = System.Drawing.Color.Black;
            this.differenceGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.differenceGraph.ChartAreas.Add(chartArea3);
            this.differenceGraph.Location = new System.Drawing.Point(13, 19);
            this.differenceGraph.Name = "differenceGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Name = "differencePlot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "differenceAvgPlot";
            this.differenceGraph.Series.Add(series3);
            this.differenceGraph.Series.Add(series4);
            this.differenceGraph.Size = new System.Drawing.Size(351, 280);
            this.differenceGraph.TabIndex = 59;
            this.differenceGraph.Text = "chart1";
            // 
            // tofGraph
            // 
            this.tofGraph.BackColor = System.Drawing.Color.Transparent;
            this.tofGraph.BorderlineColor = System.Drawing.Color.Black;
            this.tofGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.tofGraph.ChartAreas.Add(chartArea4);
            this.tofGraph.Location = new System.Drawing.Point(16, 19);
            this.tofGraph.Name = "tofGraph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series5.Name = "tofOnPlot";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series6.Name = "tofOffPlot";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Name = "tofOnAveragePlot";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Name = "tofOffAveragePlot";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Name = "tofFitPlot";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Name = "tofLowCursor";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Name = "tofHighCursor";
            this.tofGraph.Series.Add(series5);
            this.tofGraph.Series.Add(series6);
            this.tofGraph.Series.Add(series7);
            this.tofGraph.Series.Add(series8);
            this.tofGraph.Series.Add(series9);
            this.tofGraph.Series.Add(series10);
            this.tofGraph.Series.Add(series11);
            this.tofGraph.Size = new System.Drawing.Size(351, 280);
            this.tofGraph.TabIndex = 60;
            this.tofGraph.Text = "chart1";
            // 
            // pmtGraph
            // 
            this.pmtGraph.BackColor = System.Drawing.Color.Transparent;
            this.pmtGraph.BorderlineColor = System.Drawing.Color.Black;
            this.pmtGraph.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.pmtGraph.ChartAreas.Add(chartArea5);
            this.pmtGraph.Location = new System.Drawing.Point(6, 19);
            this.pmtGraph.Name = "pmtGraph";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series12.Name = "pmtOnPlot";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series13.Name = "pmtOffPlot";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Name = "pmtOnAvgPlot";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Name = "pmtOffAvgPlot";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Name = "pmtFitPlot";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series17.Name = "pmtLowCursor";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series18.Name = "pmtHighCursor";
            this.pmtGraph.Series.Add(series12);
            this.pmtGraph.Series.Add(series13);
            this.pmtGraph.Series.Add(series14);
            this.pmtGraph.Series.Add(series15);
            this.pmtGraph.Series.Add(series16);
            this.pmtGraph.Series.Add(series17);
            this.pmtGraph.Series.Add(series18);
            this.pmtGraph.Size = new System.Drawing.Size(583, 280);
            this.pmtGraph.TabIndex = 61;
            this.pmtGraph.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endTOFCursorPositionTextBox);
            this.groupBox1.Controls.Add(this.startTOFCursorPositionTextBox);
            this.groupBox1.Controls.Add(this.updateTOFCursorsButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tofGraph);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 317);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOF";
            // 
            // endTOFCursorPositionTextBox
            // 
            this.endTOFCursorPositionTextBox.Location = new System.Drawing.Point(380, 88);
            this.endTOFCursorPositionTextBox.Name = "endTOFCursorPositionTextBox";
            this.endTOFCursorPositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.endTOFCursorPositionTextBox.TabIndex = 65;
            this.endTOFCursorPositionTextBox.Text = "1";
            // 
            // startTOFCursorPositionTextBox
            // 
            this.startTOFCursorPositionTextBox.Location = new System.Drawing.Point(380, 35);
            this.startTOFCursorPositionTextBox.Name = "startTOFCursorPositionTextBox";
            this.startTOFCursorPositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.startTOFCursorPositionTextBox.TabIndex = 64;
            this.startTOFCursorPositionTextBox.Text = "0";
            // 
            // updateTOFCursorsButton
            // 
            this.updateTOFCursorsButton.Location = new System.Drawing.Point(380, 129);
            this.updateTOFCursorsButton.Name = "updateTOFCursorsButton";
            this.updateTOFCursorsButton.Size = new System.Drawing.Size(100, 41);
            this.updateTOFCursorsButton.TabIndex = 63;
            this.updateTOFCursorsButton.Text = "update TOF gates";
            this.updateTOFCursorsButton.UseVisualStyleBackColor = true;
            this.updateTOFCursorsButton.Click += new System.EventHandler(this.updateTOFCursorsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Gate: end";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Gate: start";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.analog1Graph);
            this.groupBox2.Controls.Add(this.analog2Graph);
            this.groupBox2.Location = new System.Drawing.Point(508, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 317);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analog";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.noiseResultsLabel);
            this.groupBox3.Controls.Add(this.spectrumFitModeCombo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.spectrumFitFunctionCombo);
            this.groupBox3.Controls.Add(this.spectrumFitResultsLabel);
            this.groupBox3.Controls.Add(this.updateSpectrumFitButton);
            this.groupBox3.Controls.Add(this.tofFitDataSelectCombo);
            this.groupBox3.Controls.Add(this.updateNoiseResultsbutton);
            this.groupBox3.Controls.Add(this.updateTOFFitButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tofFitResultsLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tofFitFunctionCombo);
            this.groupBox3.Controls.Add(this.tofFitModeCombo);
            this.groupBox3.Location = new System.Drawing.Point(12, 650);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1100, 70);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fitting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.endPMTCursorPositionTextBox);
            this.groupBox4.Controls.Add(this.pmtGraph);
            this.groupBox4.Controls.Add(this.startPMTCursorPositionTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.updatePMTCursorsButton);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(397, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(715, 313);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan";
            // 
            // endPMTCursorPositionTextBox
            // 
            this.endPMTCursorPositionTextBox.Location = new System.Drawing.Point(598, 88);
            this.endPMTCursorPositionTextBox.Name = "endPMTCursorPositionTextBox";
            this.endPMTCursorPositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.endPMTCursorPositionTextBox.TabIndex = 70;
            this.endPMTCursorPositionTextBox.Text = "10";
            // 
            // startPMTCursorPositionTextBox
            // 
            this.startPMTCursorPositionTextBox.Location = new System.Drawing.Point(598, 35);
            this.startPMTCursorPositionTextBox.Name = "startPMTCursorPositionTextBox";
            this.startPMTCursorPositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.startPMTCursorPositionTextBox.TabIndex = 69;
            this.startPMTCursorPositionTextBox.Text = "-10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Gate: start";
            // 
            // updatePMTCursorsButton
            // 
            this.updatePMTCursorsButton.Location = new System.Drawing.Point(598, 129);
            this.updatePMTCursorsButton.Name = "updatePMTCursorsButton";
            this.updatePMTCursorsButton.Size = new System.Drawing.Size(100, 41);
            this.updatePMTCursorsButton.TabIndex = 68;
            this.updatePMTCursorsButton.Text = "update Scan gates";
            this.updatePMTCursorsButton.UseVisualStyleBackColor = true;
            this.updatePMTCursorsButton.Click += new System.EventHandler(this.updatePMTCursorsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Gate: end";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.differenceGraph);
            this.groupBox5.Location = new System.Drawing.Point(12, 331);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(379, 313);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Difference";
            // 
            // StandardViewerWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1121, 749);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StandardViewerWindow";
            this.Text = "Standard View";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.WindowClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analog1Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog2Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tofGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmtGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
        private void updateTOFCursorsButton_Click(object sender, EventArgs e)
        {
            viewer.TOFCursorMoved();
        }
        private void updatePMTCursorsButton_Click(object sender, EventArgs e)
        {
            viewer.PMTCursorMoved();
        }
		private void tofFitModeCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			viewer.TOFFitModeChanged(((ComboBox)sender).SelectedIndex);
		}

		private void tofFitFunctionCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			viewer.TOFFitFunctionChanged(((ComboBox)sender).SelectedItem);
		}

		private void spectrumFitModeCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			viewer.SpectrumFitModeChanged(((ComboBox)sender).SelectedIndex);
		}

		private void spectrumFitFunctionCombo_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			viewer.SpectrumFitFunctionChanged(((ComboBox)sender).SelectedItem);
		}

		private void updateTOFFitButton_Click(object sender, EventArgs e)
		{
			viewer.UpdateTOFFit();
		}

		private void updateSpectrumFitButton_Click(object sender, EventArgs e)
		{
			viewer.UpdateSpectrumFit();
		}


		// these functions and properties are all thread safe
		public void ClearAll()
		{
			ClearNIGraph(analog1Graph);
			ClearNIGraph(analog2Graph);
			ClearNIGraph(pmtGraph);
			ClearNIGraph(tofGraph);
			ClearNIGraph(differenceGraph);
		}
		public void ClearSpectra()
		{
			ClearNIGraph(analog1Graph);
			ClearNIGraph(analog2Graph);
			ClearNIGraph(pmtGraph);
			ClearNIGraph(differenceGraph);
		}

		public void ClearRealtimeSpectra()
		{
			ClearNIPlot(pmtGraph, pmtGraph.Series.FindByName("pmtOnPlot"));
			ClearNIPlot(pmtGraph, pmtGraph.Series.FindByName("pmtOffPlot"));
			ClearNIPlot(differenceGraph, differenceGraph.Series.FindByName("differencePlot"));
			ClearNIPlot(analog1Graph, analog1Graph.Series.FindByName("analog1Plot"));
            ClearNIPlot(analog2Graph, analog2Graph.Series.FindByName("analog2Plot"));
		}

		public void ClearRealtimeNotAnalog()
		{
			ClearNIPlot(tofGraph, tofGraph.Series.FindByName("tofOnPlot"));
			ClearNIPlot(tofGraph, tofGraph.Series.FindByName("tofOffPlot"));
			ClearNIPlot(pmtGraph, pmtGraph.Series.FindByName("pmtOnPlot"));
			ClearNIPlot(pmtGraph, pmtGraph.Series.FindByName("pmtOffPlot"));
			ClearNIPlot(differenceGraph, differenceGraph.Series.FindByName("differencePlot"));
		}

		public void ClearSpectrumFit()
		{
            ClearNIPlot(pmtGraph, pmtGraph.Series.FindByName("pmtFitPlot"));
		}
        
		public Range SpectrumAxes
		{
			set
			{
				SetGraphXAxisRange(pmtGraph, value.Minimum, value.Maximum);
				SetGraphXAxisRange(differenceGraph, value.Minimum, value.Maximum);
				SetGraphXAxisRange(analog1Graph, value.Minimum, value.Maximum);
				SetGraphXAxisRange(analog2Graph, value.Minimum, value.Maximum);
			}
		}
        
		public Range SpectrumGate
		{
			set
			{
				MoveCursor(pmtGraph, pmtGraph.Series.FindByName("pmtLowCursor"), value.Minimum);
				MoveCursor(pmtGraph, pmtGraph.Series.FindByName("pmtHighCursor"), value.Maximum);
			}
			get
			{
				double min = GetCursorPosition(pmtGraph, pmtGraph.Series.FindByName("pmtLowCursor"));
				double max = GetCursorPosition(pmtGraph, pmtGraph.Series.FindByName("pmtHighCursor"));
				if (max <= min) max = min + 1; //highly arbitrary
				return new Range(min, max);
			}
		}
		public Range TOFGate
		{
			set
			{
				MoveCursor(tofGraph, tofGraph.Series.FindByName("tofLowCursor"), value.Minimum);
				MoveCursor(tofGraph, tofGraph.Series.FindByName("tofHighCursor"), value.Maximum);
			}
			get
			{
                double min = GetCursorPosition(tofGraph, tofGraph.Series.FindByName("tofLowCursor"));
                double max = GetCursorPosition(tofGraph, tofGraph.Series.FindByName("tofHighCursor"));
                if (max <= min) max = min + 1; //also somewhat arbitrary
                return new Range(min, max);
			}
		}

		public void PlotOnTOF(TOF t) { PlotY(tofGraph, tofGraph.Series.FindByName("tofOnPlot"), t.GateStartTime, t.ClockPeriod, t.Data); }
		public void PlotOffTOF(TOF t) { PlotY(tofGraph, tofGraph.Series.FindByName("tofOffPlot"), t.GateStartTime, t.ClockPeriod, t.Data); }
		public void PlotAverageOnTOF(TOF t)
		{
            PlotY(tofGraph, tofGraph.Series.FindByName("tofOnAveragePlot"), t.GateStartTime, t.ClockPeriod, t.Data);
		}
		public void PlotAverageOffTOF(TOF t)
		{
			PlotY(tofGraph, tofGraph.Series.FindByName("tofOffAveragePlot"), t.GateStartTime, t.ClockPeriod, t.Data);
		}
		public void AppendToAnalog1(double[] x, double[] y)
		{
			PlotXYAppend(analog1Graph, analog1Graph.Series.FindByName("analog1Plot"), x, y);
		}

		public void AppendToAnalog2(double[] x, double[] y)
		{
            PlotXYAppend(analog2Graph, analog2Graph.Series.FindByName("analog2Plot"), x, y);
		}
		public void AppendToPMTOn(double[] x, double[] y)
		{
			PlotXYAppend(pmtGraph, pmtGraph.Series.FindByName("pmtOnPlot"), x, y);
		}
		public void AppendToPMTOff(double[] x, double[] y)
		{
			PlotXYAppend(pmtGraph, pmtGraph.Series.FindByName("pmtOffPlot"), x, y);
		}
		public void AppendToDifference(double[] x, double[] y)
		{
			PlotXYAppend(differenceGraph, differenceGraph.Series.FindByName("differencePlot"), x, y);
		}

		public void PlotAveragePMTOn(double[] x, double[] y)
		{
			PlotXY(pmtGraph, pmtGraph.Series.FindByName("pmtOnAvgPlot"), x, y);
		}
		public void PlotAveragePMTOff(double[] x, double[] y)
		{
			PlotXY(pmtGraph, pmtGraph.Series.FindByName("pmtOffAvgPlot"), x, y);
		}
		public void PlotAverageDifference(double[] x, double[] y)
		{
			PlotXY(differenceGraph, differenceGraph.Series.FindByName("differenceAvgPlot"), x, y);
		}
		public void PlotSpectrumFit(double[] x, double[] y)
		{
			PlotXY(pmtGraph, pmtGraph.Series.FindByName("pmtFitPlot"), x, y);
		}

		public void ClearTOFFit()
		{
                ClearNIPlot(tofGraph, tofGraph.Series.FindByName("tofFitPlot"));
		}

		public void PlotTOFFit(int start, int period, double[] data)
		{
			PlotY(tofGraph, tofGraph.Series.FindByName("tofFitPlot"), start, period, data);
		}

		// UI delegates and thread-safe helpers
		private delegate void ClearChartDelegate(Chart chart);
		private void ClearNIGraph(Chart chart)
		{
            chart.Invoke(new ClearChartDelegate(clearChartHelper), new Object[] {chart});
		}
        private void clearChartHelper(Chart chart)
        {
            foreach (Series s in chart.Series)
            {
                s.Points.Clear();
            }
        }

        private delegate void ClearSeriesDelegate(Series s);
		private void ClearNIPlot(Chart graph, Series plot)
		{
            if (graph.IsHandleCreated)
            {
                graph.Invoke(new ClearSeriesDelegate(clearSeriesHelper), new Object[] { plot });
            }
		}
        private void clearSeriesHelper(Series s)
        {
            s.Points.Clear();

        }
		private void SetGraphXAxisRangeHelper(Chart graph, double start, double end)
		{
            graph.ChartAreas[0].AxisX.Minimum = start;
            graph.ChartAreas[0].AxisX.Maximum = end;
		}
		private delegate void SetGraphXAxisRangeDelegate(Chart graph, double start, double end);
		private void SetGraphXAxisRange(Chart graph, double start, double end)
		{
			graph.Invoke(new SetGraphXAxisRangeDelegate(SetGraphXAxisRangeHelper),
				new Object[] { graph, start, end });
		}
		private delegate void PlotXYDelegate(double[] x, double[] y);

        private delegate void seriesAppendDelegate(Series plot, double[] x, double[] y);
		private void PlotXYAppend(Chart graph, Series plot, double[] x, double[] y)
		{
            graph.Invoke(new seriesAppendDelegate(seriesAppendHelper), new Object[] { plot, x, y });
		}
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
        private void PlotXY(Chart figure, Series plot, double[] x, double[] y)
        {
            figure.Invoke(new plotSeriesDelegate(plotSeriesHelper), new object[] { plot, x, y });
        }




        private delegate void PlotYDelegate(Chart c, Series s, double start, double inc, double[] yData);
		private void PlotY(Chart graph, Series p, double start, double inc, double[] ydata)
		{
            graph.Invoke(new PlotYDelegate(plotYHelper), new Object[] { graph, p, start, inc, ydata});
		}
        private void plotYHelper(Chart chart, Series series, double start, double inc, double[] ydata)
        {
            double[] xValues = new double[ydata.Length];
            for(int i = 0; i < xValues.Length; i++)
            {
                xValues[i] = start + inc * i;
            }
            PlotXY(chart, series, xValues, ydata);
        }

        
		private void MoveCursorHelper(Chart c, Series s, double x)
		{
			s.Points.Clear();
            s.Points.AddXY(x, c.ChartAreas[0].AxisY.Minimum);
            s.Points.AddXY(x, c.ChartAreas[0].AxisY.Maximum);
		}
		private delegate void MoveCursorDelegate(Chart c, Series s, double x);
		private void MoveCursor(Chart c, Series s, double x)
		{
			c.Invoke(new MoveCursorDelegate(MoveCursorHelper), new Object[] { c, s, x });
		}

		private delegate double GetCursorPositionDelegate(Series s);
		private double GetCursorPositionHelper(Series s)
		{
			return s.Points[0].XValue;
		}
		private double GetCursorPosition(Chart graph, Series series)
		{
			double x = (double)graph.Invoke(new GetCursorPositionDelegate(GetCursorPositionHelper),
				new Object[] { series });
			return x;
		}
        public void InitializeCursors()
        {
            MoveCursor(tofGraph, tofGraph.Series.FindByName("tofLowCursor"), tofGraph.ChartAreas[0].AxisX.Minimum);
            MoveCursor(tofGraph, tofGraph.Series.FindByName("tofHighCursor"), tofGraph.ChartAreas[0].AxisX.Maximum);
            MoveCursor(pmtGraph, pmtGraph.Series.FindByName("pmtLowCursor"), pmtGraph.ChartAreas[0].AxisX.Minimum);
            MoveCursor(pmtGraph, pmtGraph.Series.FindByName("pmtHighCursor"), pmtGraph.ChartAreas[0].AxisX.Maximum);
            startTOFCursorPositionTextBox.Text = tofGraph.ChartAreas[0].AxisX.Minimum.ToString();
            endTOFCursorPositionTextBox.Text = tofGraph.ChartAreas[0].AxisX.Maximum.ToString();
            startPMTCursorPositionTextBox.Text = pmtGraph.ChartAreas[0].AxisX.Minimum.ToString();
            endPMTCursorPositionTextBox.Text = pmtGraph.ChartAreas[0].AxisX.Maximum.ToString();
        }

		public void SetLabel(Label label, string text)
		{
			label.Invoke(new SetLabelDelegate(SetLabelHelper), new object[] { label, text });
		}
		private delegate void SetLabelDelegate(Label label, string text);
		private void SetLabelHelper(Label label, string text)
		{
			label.Text = text;
		}

        public void SetStatus(string text)
        {
            this.Invoke(new SetStatusDelegate(SetStatusHelper), new object[] { text });
        }
        public void SetTOFStatus(string text)
        {
            this.Invoke(new SetStatusDelegate(SetTOFStatusHelper), new object[] { text });
        }
        private delegate void SetStatusDelegate(string text);
        private void SetStatusHelper(string text)
        {
            statusBar1.Text = text;
        }
        private void SetTOFStatusHelper(string text)
        {
            statusBar2.Text = text;
        }

        private void TofFitComboHelper(bool state)
        {
            tofFitFunctionCombo.Enabled = state;
        }
        private delegate void ComboStateDelegate(bool state);
        public void SetTofFitFunctionComboState(bool state)
        {
            tofFitFunctionCombo.Invoke(new ComboStateDelegate(TofFitComboHelper), state);
        }

        private int TofFitDataSelectHelper()
        {
            return tofFitDataSelectCombo.SelectedIndex;
        }
        private delegate int TofFitDataDelegate();
        public int GetTofFitDataSelection()
        {
            return (int) tofFitDataSelectCombo.Invoke(new TofFitDataDelegate(TofFitDataSelectHelper));
        }

        private void SpectrumFitComboHelper(bool state)
        {
            spectrumFitFunctionCombo.Enabled = state;
        }
        public void SetSpectrumFitFunctionComboState(bool state)
        {
            spectrumFitFunctionCombo.Invoke(new ComboStateDelegate(SpectrumFitComboHelper), state);
        }

		private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			viewer.ToggleVisible();
			e.Cancel = true;
		}

        private void updateNoiseResultsbutton_Click(object sender, EventArgs e)
        {
            viewer.UpdateNoiseResults();
        }


        private void defaultGateButton_Click(object sender, EventArgs e)
        {
            viewer.SetGatesToDefault();
        }






	}
}
