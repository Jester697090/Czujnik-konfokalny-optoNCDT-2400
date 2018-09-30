namespace Projekt
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.measurementChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stageDeltaGroupBox = new System.Windows.Forms.GroupBox();
            this.stageDeltaUnitLabel = new System.Windows.Forms.Label();
            this.stageDeltaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stageDeltaLabel = new System.Windows.Forms.Label();
            this.actionsGroupBox = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteOneButton = new System.Windows.Forms.Button();
            this.newMeasurementButton = new System.Windows.Forms.Button();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.extremeDistanceLabel = new System.Windows.Forms.Label();
            this.amplitudeValue = new System.Windows.Forms.TextBox();
            this.maxDistanceValue = new System.Windows.Forms.TextBox();
            this.minDistanceValue = new System.Windows.Forms.TextBox();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceDifferenceValue = new System.Windows.Forms.TextBox();
            this.lastDistanceValue = new System.Windows.Forms.TextBox();
            this.lastButOneDistanceValue = new System.Windows.Forms.TextBox();
            this.stageLabel = new System.Windows.Forms.Label();
            this.stageDifferenceValue = new System.Windows.Forms.TextBox();
            this.lastStageValue = new System.Windows.Forms.TextBox();
            this.lastButOneStageValue = new System.Windows.Forms.TextBox();
            this.differenceLabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.lastButOneLabel = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.information = new System.Windows.Forms.TextBox();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.saveChartButton = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementChart)).BeginInit();
            this.stageDeltaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageDeltaNumericUpDown)).BeginInit();
            this.actionsGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.measurementChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stageDeltaGroupBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.actionsGroupBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGroupBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.icon, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.information, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.saveDataButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.saveChartButton, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // measurementChart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Title = "Położenie stolika x [um]";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.LabelStyle.Format = "0.00";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.measurementChart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.measurementChart, 3);
            this.measurementChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.White;
            legend1.BorderColor = System.Drawing.Color.DarkGray;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.measurementChart.Legends.Add(legend1);
            this.measurementChart.Location = new System.Drawing.Point(3, 3);
            this.measurementChart.Name = "measurementChart";
            this.measurementChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.tableLayoutPanel1.SetRowSpan(this.measurementChart, 4);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "ErrorBars";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.YValuesPerPoint = 3;
            this.measurementChart.Series.Add(series1);
            this.measurementChart.Series.Add(series2);
            this.measurementChart.Size = new System.Drawing.Size(437, 310);
            this.measurementChart.TabIndex = 0;
            this.measurementChart.Text = "Wykres";
            this.measurementChart.Click += new System.EventHandler(this.measurementChart_Click);
            // 
            // stageDeltaGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.stageDeltaGroupBox, 3);
            this.stageDeltaGroupBox.Controls.Add(this.stageDeltaUnitLabel);
            this.stageDeltaGroupBox.Controls.Add(this.stageDeltaNumericUpDown);
            this.stageDeltaGroupBox.Controls.Add(this.stageDeltaLabel);
            this.stageDeltaGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stageDeltaGroupBox.Location = new System.Drawing.Point(446, 3);
            this.stageDeltaGroupBox.Name = "stageDeltaGroupBox";
            this.stageDeltaGroupBox.Size = new System.Drawing.Size(135, 73);
            this.stageDeltaGroupBox.TabIndex = 1;
            this.stageDeltaGroupBox.TabStop = false;
            this.stageDeltaGroupBox.Text = "Ruch stolika:";
            // 
            // stageDeltaUnitLabel
            // 
            this.stageDeltaUnitLabel.AutoSize = true;
            this.stageDeltaUnitLabel.Location = new System.Drawing.Point(93, 39);
            this.stageDeltaUnitLabel.Name = "stageDeltaUnitLabel";
            this.stageDeltaUnitLabel.Size = new System.Drawing.Size(27, 13);
            this.stageDeltaUnitLabel.TabIndex = 2;
            this.stageDeltaUnitLabel.Text = "[um]";
            // 
            // stageDeltaNumericUpDown
            // 
            this.stageDeltaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stageDeltaNumericUpDown.Location = new System.Drawing.Point(7, 37);
            this.stageDeltaNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.stageDeltaNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stageDeltaNumericUpDown.Name = "stageDeltaNumericUpDown";
            this.stageDeltaNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.stageDeltaNumericUpDown.TabIndex = 1;
            this.stageDeltaNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stageDeltaNumericUpDown.ValueChanged += new System.EventHandler(this.stageDeltaNumericUpDown_ValueChanged);
            // 
            // stageDeltaLabel
            // 
            this.stageDeltaLabel.AutoSize = true;
            this.stageDeltaLabel.Location = new System.Drawing.Point(6, 20);
            this.stageDeltaLabel.Name = "stageDeltaLabel";
            this.stageDeltaLabel.Size = new System.Drawing.Size(91, 13);
            this.stageDeltaLabel.TabIndex = 0;
            this.stageDeltaLabel.Text = "Przesunięcie co...";
            // 
            // actionsGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.actionsGroupBox, 3);
            this.actionsGroupBox.Controls.Add(this.resetButton);
            this.actionsGroupBox.Controls.Add(this.deleteOneButton);
            this.actionsGroupBox.Controls.Add(this.newMeasurementButton);
            this.actionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsGroupBox.Location = new System.Drawing.Point(446, 82);
            this.actionsGroupBox.Name = "actionsGroupBox";
            this.actionsGroupBox.Size = new System.Drawing.Size(135, 82);
            this.actionsGroupBox.TabIndex = 2;
            this.actionsGroupBox.TabStop = false;
            this.actionsGroupBox.Text = "Pomiar:";
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(69, 48);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(58, 23);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteOneButton
            // 
            this.deleteOneButton.Enabled = false;
            this.deleteOneButton.Location = new System.Drawing.Point(7, 48);
            this.deleteOneButton.Name = "deleteOneButton";
            this.deleteOneButton.Size = new System.Drawing.Size(58, 23);
            this.deleteOneButton.TabIndex = 1;
            this.deleteOneButton.Text = "Usuń 1";
            this.deleteOneButton.UseVisualStyleBackColor = true;
            this.deleteOneButton.Click += new System.EventHandler(this.deleteOneButton_Click);
            // 
            // newMeasurementButton
            // 
            this.newMeasurementButton.Location = new System.Drawing.Point(7, 19);
            this.newMeasurementButton.Name = "newMeasurementButton";
            this.newMeasurementButton.Size = new System.Drawing.Size(120, 23);
            this.newMeasurementButton.TabIndex = 0;
            this.newMeasurementButton.Text = "Nowy pomiar";
            this.newMeasurementButton.UseVisualStyleBackColor = true;
            this.newMeasurementButton.Click += new System.EventHandler(this.newMeasurementButton_Click);
            // 
            // dataGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dataGroupBox, 3);
            this.dataGroupBox.Controls.Add(this.extremeDistanceLabel);
            this.dataGroupBox.Controls.Add(this.amplitudeValue);
            this.dataGroupBox.Controls.Add(this.maxDistanceValue);
            this.dataGroupBox.Controls.Add(this.minDistanceValue);
            this.dataGroupBox.Controls.Add(this.amplitudeLabel);
            this.dataGroupBox.Controls.Add(this.maxLabel);
            this.dataGroupBox.Controls.Add(this.minLabel);
            this.dataGroupBox.Controls.Add(this.distanceLabel);
            this.dataGroupBox.Controls.Add(this.distanceDifferenceValue);
            this.dataGroupBox.Controls.Add(this.lastDistanceValue);
            this.dataGroupBox.Controls.Add(this.lastButOneDistanceValue);
            this.dataGroupBox.Controls.Add(this.stageLabel);
            this.dataGroupBox.Controls.Add(this.stageDifferenceValue);
            this.dataGroupBox.Controls.Add(this.lastStageValue);
            this.dataGroupBox.Controls.Add(this.lastButOneStageValue);
            this.dataGroupBox.Controls.Add(this.differenceLabel);
            this.dataGroupBox.Controls.Add(this.lastLabel);
            this.dataGroupBox.Controls.Add(this.lastButOneLabel);
            this.dataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGroupBox.Location = new System.Drawing.Point(3, 319);
            this.dataGroupBox.Name = "dataGroupBox";
            this.tableLayoutPanel1.SetRowSpan(this.dataGroupBox, 2);
            this.dataGroupBox.Size = new System.Drawing.Size(437, 119);
            this.dataGroupBox.TabIndex = 3;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Dane pomiarowe:";
            // 
            // extremeDistanceLabel
            // 
            this.extremeDistanceLabel.AutoSize = true;
            this.extremeDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extremeDistanceLabel.Location = new System.Drawing.Point(365, 16);
            this.extremeDistanceLabel.Name = "extremeDistanceLabel";
            this.extremeDistanceLabel.Size = new System.Drawing.Size(56, 9);
            this.extremeDistanceLabel.TabIndex = 17;
            this.extremeDistanceLabel.Text = "Odległość [um]";
            // 
            // amplitudeValue
            // 
            this.amplitudeValue.Location = new System.Drawing.Point(363, 91);
            this.amplitudeValue.Name = "amplitudeValue";
            this.amplitudeValue.ReadOnly = true;
            this.amplitudeValue.Size = new System.Drawing.Size(60, 20);
            this.amplitudeValue.TabIndex = 16;
            // 
            // maxDistanceValue
            // 
            this.maxDistanceValue.Location = new System.Drawing.Point(363, 52);
            this.maxDistanceValue.Name = "maxDistanceValue";
            this.maxDistanceValue.ReadOnly = true;
            this.maxDistanceValue.Size = new System.Drawing.Size(60, 20);
            this.maxDistanceValue.TabIndex = 15;
            // 
            // minDistanceValue
            // 
            this.minDistanceValue.Location = new System.Drawing.Point(363, 29);
            this.minDistanceValue.Name = "minDistanceValue";
            this.minDistanceValue.ReadOnly = true;
            this.minDistanceValue.Size = new System.Drawing.Size(60, 20);
            this.minDistanceValue.TabIndex = 14;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(291, 94);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(53, 13);
            this.amplitudeLabel.TabIndex = 13;
            this.amplitudeLabel.Text = "Amplituda";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(291, 55);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(57, 13);
            this.maxLabel.TabIndex = 12;
            this.maxLabel.Text = "Maksimum";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(291, 32);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(48, 13);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Minimum";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distanceLabel.Location = new System.Drawing.Point(198, 16);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(56, 9);
            this.distanceLabel.TabIndex = 10;
            this.distanceLabel.Text = "Odległość [um]";
            // 
            // distanceDifferenceValue
            // 
            this.distanceDifferenceValue.Location = new System.Drawing.Point(196, 91);
            this.distanceDifferenceValue.Name = "distanceDifferenceValue";
            this.distanceDifferenceValue.ReadOnly = true;
            this.distanceDifferenceValue.Size = new System.Drawing.Size(60, 20);
            this.distanceDifferenceValue.TabIndex = 9;
            // 
            // lastDistanceValue
            // 
            this.lastDistanceValue.Location = new System.Drawing.Point(196, 52);
            this.lastDistanceValue.Name = "lastDistanceValue";
            this.lastDistanceValue.ReadOnly = true;
            this.lastDistanceValue.Size = new System.Drawing.Size(60, 20);
            this.lastDistanceValue.TabIndex = 8;
            // 
            // lastButOneDistanceValue
            // 
            this.lastButOneDistanceValue.Location = new System.Drawing.Point(196, 29);
            this.lastButOneDistanceValue.Name = "lastButOneDistanceValue";
            this.lastButOneDistanceValue.ReadOnly = true;
            this.lastButOneDistanceValue.Size = new System.Drawing.Size(60, 20);
            this.lastButOneDistanceValue.TabIndex = 7;
            // 
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stageLabel.Location = new System.Drawing.Point(122, 16);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(59, 9);
            this.stageLabel.TabIndex = 6;
            this.stageLabel.Text = "Poł. stolika [um]";
            // 
            // stageDifferenceValue
            // 
            this.stageDifferenceValue.Location = new System.Drawing.Point(121, 91);
            this.stageDifferenceValue.Name = "stageDifferenceValue";
            this.stageDifferenceValue.ReadOnly = true;
            this.stageDifferenceValue.Size = new System.Drawing.Size(60, 20);
            this.stageDifferenceValue.TabIndex = 5;
            // 
            // lastStageValue
            // 
            this.lastStageValue.Location = new System.Drawing.Point(121, 52);
            this.lastStageValue.Name = "lastStageValue";
            this.lastStageValue.ReadOnly = true;
            this.lastStageValue.Size = new System.Drawing.Size(60, 20);
            this.lastStageValue.TabIndex = 4;
            // 
            // lastButOneStageValue
            // 
            this.lastButOneStageValue.Location = new System.Drawing.Point(121, 29);
            this.lastButOneStageValue.Name = "lastButOneStageValue";
            this.lastButOneStageValue.ReadOnly = true;
            this.lastButOneStageValue.Size = new System.Drawing.Size(60, 20);
            this.lastButOneStageValue.TabIndex = 3;
            // 
            // differenceLabel
            // 
            this.differenceLabel.AutoSize = true;
            this.differenceLabel.Location = new System.Drawing.Point(9, 94);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(46, 13);
            this.differenceLabel.TabIndex = 2;
            this.differenceLabel.Text = "Różnica";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Location = new System.Drawing.Point(9, 55);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(74, 13);
            this.lastLabel.TabIndex = 1;
            this.lastLabel.Text = "Ostatni pomiar";
            // 
            // lastButOneLabel
            // 
            this.lastButOneLabel.AutoSize = true;
            this.lastButOneLabel.Location = new System.Drawing.Point(9, 32);
            this.lastButOneLabel.Name = "lastButOneLabel";
            this.lastButOneLabel.Size = new System.Drawing.Size(99, 13);
            this.lastButOneLabel.TabIndex = 0;
            this.lastButOneLabel.Text = "Przedostatni pomiar";
            // 
            // icon
            // 
            this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icon.Location = new System.Drawing.Point(492, 170);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(40, 38);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            // 
            // information
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.information, 3);
            this.information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information.Location = new System.Drawing.Point(446, 214);
            this.information.Multiline = true;
            this.information.Name = "information";
            this.information.ReadOnly = true;
            this.information.Size = new System.Drawing.Size(135, 99);
            this.information.TabIndex = 5;
            // 
            // saveDataButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.saveDataButton, 3);
            this.saveDataButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveDataButton.Location = new System.Drawing.Point(446, 344);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(135, 30);
            this.saveDataButton.TabIndex = 6;
            this.saveDataButton.Text = "Zapisz dane";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // saveChartButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.saveChartButton, 3);
            this.saveChartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveChartButton.Location = new System.Drawing.Point(446, 380);
            this.saveChartButton.Name = "saveChartButton";
            this.saveChartButton.Size = new System.Drawing.Size(135, 30);
            this.saveChartButton.TabIndex = 7;
            this.saveChartButton.Text = "Zapisz wykres";
            this.saveChartButton.UseVisualStyleBackColor = true;
            this.saveChartButton.Click += new System.EventHandler(this.saveChartButton_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "optoNCDT 2400 - Pomiar wielokrotny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measurementChart)).EndInit();
            this.stageDeltaGroupBox.ResumeLayout(false);
            this.stageDeltaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stageDeltaNumericUpDown)).EndInit();
            this.actionsGroupBox.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart measurementChart;
        private System.Windows.Forms.GroupBox stageDeltaGroupBox;
        private System.Windows.Forms.Label stageDeltaUnitLabel;
        private System.Windows.Forms.NumericUpDown stageDeltaNumericUpDown;
        private System.Windows.Forms.Label stageDeltaLabel;
        private System.Windows.Forms.GroupBox actionsGroupBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button deleteOneButton;
        private System.Windows.Forms.Button newMeasurementButton;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.TextBox amplitudeValue;
        private System.Windows.Forms.TextBox maxDistanceValue;
        private System.Windows.Forms.TextBox minDistanceValue;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox distanceDifferenceValue;
        private System.Windows.Forms.TextBox lastDistanceValue;
        private System.Windows.Forms.TextBox lastButOneDistanceValue;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.TextBox stageDifferenceValue;
        private System.Windows.Forms.TextBox lastStageValue;
        private System.Windows.Forms.TextBox lastButOneStageValue;
        private System.Windows.Forms.Label differenceLabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.Label lastButOneLabel;
        private System.Windows.Forms.Label extremeDistanceLabel;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.TextBox information;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button saveChartButton;
        private System.Windows.Forms.Timer updateTimer;
    }
}