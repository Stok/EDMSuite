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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TwoCursorChart tofCursorChart;
        private TwoCursorChart pmtCursorChart;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem getTofOnOffIntegralArrayToolStripMenuItem;
        private ToolStripMenuItem tOFToolStripMenuItem;
        private ToolStripMenuItem integralToolStripMenuItem;
        private ToolStripMenuItem integralOfAbsValToolStripMenuItem;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integralOfAbsValToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTofOnOffIntegralArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pmtCursorChart = new ScanMaster.GUI.TwoCursorChart();
            this.tofCursorChart = new ScanMaster.GUI.TwoCursorChart();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 910);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusBar1);
            this.splitContainer1.Size = new System.Drawing.Size(1031, 23);
            this.splitContainer1.SplitterDistance = 391;
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
            this.splitContainer2.Size = new System.Drawing.Size(391, 23);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 0;
            // 
            // statusBar2
            // 
            this.statusBar2.Location = new System.Drawing.Point(0, 0);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Size = new System.Drawing.Size(246, 23);
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
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 0);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(636, 23);
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
            this.analog1Graph.Dock = System.Windows.Forms.DockStyle.Top;
            this.analog1Graph.Location = new System.Drawing.Point(3, 16);
            this.analog1Graph.Name = "analog1Graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "analog1Plot";
            this.analog1Graph.Series.Add(series1);
            this.analog1Graph.Size = new System.Drawing.Size(598, 143);
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
            this.analog2Graph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.analog2Graph.Location = new System.Drawing.Point(3, 166);
            this.analog2Graph.Name = "analog2Graph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Name = "analog2Plot";
            this.analog2Graph.Series.Add(series2);
            this.analog2Graph.Size = new System.Drawing.Size(598, 149);
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
            this.differenceGraph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.differenceGraph.Location = new System.Drawing.Point(3, 21);
            this.differenceGraph.Name = "differenceGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Name = "differencePlot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "differenceAvgPlot";
            this.differenceGraph.Series.Add(series3);
            this.differenceGraph.Series.Add(series4);
            this.differenceGraph.Size = new System.Drawing.Size(397, 294);
            this.differenceGraph.TabIndex = 59;
            this.differenceGraph.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tofCursorChart);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 464);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.analog1Graph);
            this.groupBox2.Controls.Add(this.analog2Graph);
            this.groupBox2.Location = new System.Drawing.Point(424, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 318);
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 840);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1031, 70);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fitting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pmtCursorChart);
            this.groupBox4.Location = new System.Drawing.Point(424, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 464);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scan";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.differenceGraph);
            this.groupBox5.Location = new System.Drawing.Point(9, 512);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 318);
            this.groupBox5.TabIndex = 65;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Difference";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integralToolStripMenuItem,
            this.integralOfAbsValToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.displayToolStripMenuItem.Text = "Scan Display Mode";
            // 
            // integralToolStripMenuItem
            // 
            this.integralToolStripMenuItem.Checked = true;
            this.integralToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.integralToolStripMenuItem.Name = "integralToolStripMenuItem";
            this.integralToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.integralToolStripMenuItem.Text = "Integral";
            this.integralToolStripMenuItem.Click += new System.EventHandler(this.integralToolStripMenuItem_Click);
            // 
            // integralOfAbsValToolStripMenuItem
            // 
            this.integralOfAbsValToolStripMenuItem.Name = "integralOfAbsValToolStripMenuItem";
            this.integralOfAbsValToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.integralOfAbsValToolStripMenuItem.Text = "Integral of abs val";
            this.integralOfAbsValToolStripMenuItem.Click += new System.EventHandler(this.integralOfAbsValToolStripMenuItem_Click);
            // 
            // getTofOnOffIntegralArrayToolStripMenuItem
            // 
            this.getTofOnOffIntegralArrayToolStripMenuItem.Name = "getTofOnOffIntegralArrayToolStripMenuItem";
            this.getTofOnOffIntegralArrayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            // 
            // tOFToolStripMenuItem
            // 
            this.tOFToolStripMenuItem.Name = "tOFToolStripMenuItem";
            this.tOFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            // 
            // pmtCursorChart
            // 
            this.pmtCursorChart.AutoSize = true;
            this.pmtCursorChart.Location = new System.Drawing.Point(6, 13);
            this.pmtCursorChart.Name = "pmtCursorChart";
            this.pmtCursorChart.Size = new System.Drawing.Size(595, 438);
            this.pmtCursorChart.TabIndex = 62;
            this.pmtCursorChart.LowCursorValueChanged += new System.EventHandler(this.pmtCursorChart_LowCursorValueChanged);
            this.pmtCursorChart.HighCursorValueChanged += new System.EventHandler(this.pmtCursorChart_HighCursorValueChanged);
            // 
            // tofCursorChart
            // 
            this.tofCursorChart.AutoSize = true;
            this.tofCursorChart.Location = new System.Drawing.Point(3, 13);
            this.tofCursorChart.Name = "tofCursorChart";
            this.tofCursorChart.Size = new System.Drawing.Size(388, 438);
            this.tofCursorChart.TabIndex = 62;
            this.tofCursorChart.LowCursorValueChanged += new System.EventHandler(this.tofCursorChart_LowCursorValueChanged);
            this.tofCursorChart.HighCursorValueChanged += new System.EventHandler(this.tofCursorChart_HighCursorValueChanged);
            // 
            // StandardViewerWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1031, 933);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        
        private void tofCursorChart_LowCursorValueChanged(object sender, System.EventArgs e)
        {
            MoveLowCursor(tofCursorChart, tofCursorChart.GetLowCursorValue());
        }
        private void tofCursorChart_HighCursorValueChanged(object sender, System.EventArgs e)
        {
            MoveHighCursor(tofCursorChart, tofCursorChart.GetHighCursorValue());
        }

        private void pmtCursorChart_LowCursorValueChanged(object sender, System.EventArgs e)
        {
            MoveLowCursor(pmtCursorChart, pmtCursorChart.GetLowCursorValue());
        }
        private void pmtCursorChart_HighCursorValueChanged(object sender, System.EventArgs e)
        {
            MoveHighCursor(pmtCursorChart, pmtCursorChart.GetHighCursorValue());
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
			clearChart(analog1Graph);
			clearChart(analog2Graph);
			pmtCursorChart.ClearChart();
            tofCursorChart.ClearChart();
			clearChart(differenceGraph);
		}
		public void ClearSpectra()
		{
			clearChart(analog1Graph);
			clearChart(analog2Graph);
            pmtCursorChart.ClearChart();
			clearChart(differenceGraph);
		}

		public void ClearRealtimeSpectra()
		{
			pmtCursorChart.ClearSeries(pmtCursorChart.GetSeriesByName("onPlot"));
			pmtCursorChart.ClearSeries(pmtCursorChart.GetSeriesByName("offPlot"));
			clearSeries(differenceGraph, differenceGraph.Series.FindByName("differencePlot"));
			clearSeries(analog1Graph, analog1Graph.Series.FindByName("analog1Plot"));
            clearSeries(analog2Graph, analog2Graph.Series.FindByName("analog2Plot"));
		}

		public void ClearRealtimeNotAnalog()
		{
			tofCursorChart.ClearSeries(tofCursorChart.GetSeriesByName("onPlot"));
			tofCursorChart.ClearSeries(tofCursorChart.GetSeriesByName("offPlot"));
            pmtCursorChart.ClearSeries(pmtCursorChart.GetSeriesByName("onPlot"));
            pmtCursorChart.ClearSeries(pmtCursorChart.GetSeriesByName("offPlot"));
			clearSeries(differenceGraph, differenceGraph.Series.FindByName("differencePlot"));
		}

		public void ClearSpectrumFit()
		{
            pmtCursorChart.ClearSeries(pmtCursorChart.GetSeriesByName("pmtFitPlot"));
		}
        
		public PlotParameters SpectrumAxes
		{
			set
			{
                pmtCursorChart.InitializeTwoCursorChart(value, false);
				SetGraphXAxisRange(differenceGraph, value);
				SetGraphXAxisRange(analog1Graph, value);
				SetGraphXAxisRange(analog2Graph, value);
			}
		}
        
		public PlotParameters SpectrumGate
		{
			set
			{
                pmtCursorChart.InitializeTwoCursorChart(value, false);
				MoveLowCursor(pmtCursorChart, value.Minimum);
				MoveHighCursor(pmtCursorChart, value.Maximum);
			}
			get
			{
				double min = GetLowCursorPosition(pmtCursorChart);
				double max = GetHighCursorPosition(pmtCursorChart);
				if (max <= min) max = min + 1; //highly arbitrary
				return new PlotParameters(min, max);
			}
		}
		public PlotParameters TOFGate
		{
			set
			{
                tofCursorChart.InitializeTwoCursorChart(value, true);
			}
			get
			{
                double min = GetLowCursorPosition(tofCursorChart);
                double max = GetHighCursorPosition(tofCursorChart);
                if (max <= min) max = min + 1; //also somewhat arbitrary
                return new PlotParameters(min, max);
			}
		}

		public void PlotOnTOF(TOF t) { tofCursorChart.PlotY(tofCursorChart.GetSeriesByName("onPlot"), t.GateStartTime, t.ClockPeriod, t.Data); }
		public void PlotOffTOF(TOF t) { tofCursorChart.PlotY(tofCursorChart.GetSeriesByName("offPlot"), t.GateStartTime, t.ClockPeriod, t.Data); }
		public void PlotAverageOnTOF(TOF t)
		{
            tofCursorChart.PlotY(tofCursorChart.GetSeriesByName("onAveragePlot"), t.GateStartTime, t.ClockPeriod, t.Data);
		}
		public void PlotAverageOffTOF(TOF t)
		{
			tofCursorChart.PlotY(tofCursorChart.GetSeriesByName("offAveragePlot"), t.GateStartTime, t.ClockPeriod, t.Data);
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
            pmtCursorChart.PlotXYAppend(pmtCursorChart.GetSeriesByName("onPlot"), x, y);
		}
		public void AppendToPMTOff(double[] x, double[] y)
		{
            pmtCursorChart.PlotXYAppend(pmtCursorChart.GetSeriesByName("offPlot"), x, y);
		}
		public void AppendToDifference(double[] x, double[] y)
		{
			PlotXYAppend(differenceGraph, differenceGraph.Series.FindByName("differencePlot"), x, y);
		}

		public void PlotAveragePMTOn(double[] x, double[] y)
		{
            pmtCursorChart.PlotXY(pmtCursorChart.GetSeriesByName("onAveragePlot"), x, y);
		}
		public void PlotAveragePMTOff(double[] x, double[] y)
		{
            pmtCursorChart.PlotXY(pmtCursorChart.GetSeriesByName("offAveragePlot"), x, y);
		}
		public void PlotAverageDifference(double[] x, double[] y)
		{
			PlotXY(differenceGraph, differenceGraph.Series.FindByName("differenceAvgPlot"), x, y);
		}
		public void PlotSpectrumFit(double[] x, double[] y)
		{
			pmtCursorChart.PlotXY(pmtCursorChart.GetSeriesByName("fitPlot"), x, y);
		}

		public void ClearTOFFit()
		{
            tofCursorChart.ClearSeries(tofCursorChart.GetSeriesByName("fitPlot"));
		}

		public void PlotTOFFit(int start, int period, double[] data)
		{
			tofCursorChart.PlotY(tofCursorChart.GetSeriesByName("fitPlot"), start, period, data);
		}

		// UI delegates and thread-safe helpers
		private delegate void ClearChartDelegate(Chart chart);
		private void clearChart(Chart chart)
		{
            chart.Invoke(new ClearChartDelegate(clearChartHelper), new Object[] {chart});
		}
        private void clearChartHelper(Chart chart)
        {
            foreach (Series s in chart.Series)
            {
                if (IsHandleCreated)
                {
                    s.Points.Clear();
                }
            }
        }

        private delegate void ClearSeriesDelegate(Chart c,Series s);
		private void clearSeries(Chart graph, Series plot)
		{
            if (graph.IsHandleCreated)
            {
                graph.Invoke(new ClearSeriesDelegate(clearSeriesHelper), new Object[] {graph,  plot });
            }
		}
        private void clearSeriesHelper(Chart c, Series s)
        {
            if(c.IsHandleCreated)
            { 
                s.Points.Clear();
            }
        }
		private void SetGraphXAxisRangeHelper(Chart graph, PlotParameters range)
		{
            graph.ChartAreas[0].AxisX.Minimum = range.Minimum;
            graph.ChartAreas[0].AxisX.Maximum = range.Maximum;
		}
		private delegate void SetGraphXAxisRangeDelegate(Chart graph, PlotParameters range);
		private void SetGraphXAxisRange(Chart graph, PlotParameters range)
		{
			graph.Invoke(new SetGraphXAxisRangeDelegate(SetGraphXAxisRangeHelper),
				new Object[] { graph, range });
		}


        private delegate void seriesAppendDelegate(Series plot, double[] x, double[] y);
		private void PlotXYAppend(Chart graph, Series plot, double[] x, double[] y)
		{
            if (graph.IsHandleCreated)
            {
                graph.Invoke(new seriesAppendDelegate(seriesAppendHelper), new Object[] { plot, x, y });
            }
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
                seriesAppendHelper(plot, x, y);
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
            chart.ChartAreas[0].AxisX.Minimum = start;
            chart.ChartAreas[0].AxisX.Maximum = xValues[xValues.Length-1];
            PlotXY(chart, series, xValues, ydata);
        }

		private void MoveLowCursor(TwoCursorChart c, double x)
		{
            c.UpdateLowCursorPosition(x);
		}

        private void MoveHighCursor(TwoCursorChart c, double x)
        {
            c.UpdateHighCursorPosition(x);
        }

        private double GetLowCursorPosition(TwoCursorChart graph)
        {
            return graph.GetLowCursorValue();
        }
		private double GetHighCursorPosition(TwoCursorChart graph)
		{
			return graph.GetHighCursorValue();
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

        private void integralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            integralToolStripMenuItem.Checked = true;
            integralOfAbsValToolStripMenuItem.Checked = false;
            viewer.ScanDisplayModeChanged(0);
        }

        private void integralOfAbsValToolStripMenuItem_Click(object sender, EventArgs e)
        {
            integralToolStripMenuItem.Checked = false;
            integralOfAbsValToolStripMenuItem.Checked = true;
            viewer.ScanDisplayModeChanged(1);
        }










	}
}
