namespace Projekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.information = new System.Windows.Forms.TextBox();
            this.measurementTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.currentMeasurementTypeLabel = new System.Windows.Forms.Label();
            this.saveToEEPROMButton1 = new System.Windows.Forms.Button();
            this.measurementTypeLabel = new System.Windows.Forms.Label();
            this.measurementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.currentMeasurementBox = new System.Windows.Forms.GroupBox();
            this.thicknessErrorValue = new System.Windows.Forms.TextBox();
            this.thicknessErrorLabel = new System.Windows.Forms.Label();
            this.thicknessValue = new System.Windows.Forms.TextBox();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.distanceErrorValue2 = new System.Windows.Forms.TextBox();
            this.distanceValue2 = new System.Windows.Forms.TextBox();
            this.intensityValue2 = new System.Windows.Forms.TextBox();
            this.distanceErrorLabel2 = new System.Windows.Forms.Label();
            this.distanceLabel2 = new System.Windows.Forms.Label();
            this.intensityLabel2 = new System.Windows.Forms.Label();
            this.distanceValue = new System.Windows.Forms.TextBox();
            this.distanceErrorValue = new System.Windows.Forms.TextBox();
            this.intensityValue = new System.Windows.Forms.TextBox();
            this.distanceErrorLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.intensityLabel = new System.Windows.Forms.Label();
            this.multipleMeasurementButton = new System.Windows.Forms.Button();
            this.portChoiceBox = new System.Windows.Forms.GroupBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.sampleTypeBox = new System.Windows.Forms.GroupBox();
            this.sampleComboBox = new System.Windows.Forms.ComboBox();
            this.sampleTypeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkSpectrumGroupBox = new System.Windows.Forms.GroupBox();
            this.standardDarkRadioButton = new System.Windows.Forms.RadioButton();
            this.fastDarkRadioButton = new System.Windows.Forms.RadioButton();
            this.calibrateDarkButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingsTimer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.measurementTypeGroupBox.SuspendLayout();
            this.currentMeasurementBox.SuspendLayout();
            this.portChoiceBox.SuspendLayout();
            this.sampleTypeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkSpectrumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.information, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.measurementTypeGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentMeasurementBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.multipleMeasurementButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.portChoiceBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sampleTypeBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.darkSpectrumGroupBox, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // information
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.information, 4);
            this.information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information.Location = new System.Drawing.Point(100, 240);
            this.information.Multiline = true;
            this.information.Name = "information";
            this.information.ReadOnly = true;
            this.information.Size = new System.Drawing.Size(382, 161);
            this.information.TabIndex = 2;
            // 
            // measurementTypeGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.measurementTypeGroupBox, 2);
            this.measurementTypeGroupBox.Controls.Add(this.currentMeasurementTypeLabel);
            this.measurementTypeGroupBox.Controls.Add(this.saveToEEPROMButton1);
            this.measurementTypeGroupBox.Controls.Add(this.measurementTypeLabel);
            this.measurementTypeGroupBox.Controls.Add(this.measurementTypeComboBox);
            this.measurementTypeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measurementTypeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.measurementTypeGroupBox.Name = "measurementTypeGroupBox";
            this.measurementTypeGroupBox.Size = new System.Drawing.Size(188, 73);
            this.measurementTypeGroupBox.TabIndex = 9;
            this.measurementTypeGroupBox.TabStop = false;
            this.measurementTypeGroupBox.Text = "Wybór trybu pomiaru:";
            // 
            // currentMeasurementTypeLabel
            // 
            this.currentMeasurementTypeLabel.AutoSize = true;
            this.currentMeasurementTypeLabel.Location = new System.Drawing.Point(98, 22);
            this.currentMeasurementTypeLabel.Name = "currentMeasurementTypeLabel";
            this.currentMeasurementTypeLabel.Size = new System.Drawing.Size(57, 13);
            this.currentMeasurementTypeLabel.TabIndex = 6;
            this.currentMeasurementTypeLabel.Text = "Aktualnie: ";
            // 
            // saveToEEPROMButton1
            // 
            this.saveToEEPROMButton1.Enabled = false;
            this.saveToEEPROMButton1.Location = new System.Drawing.Point(94, 37);
            this.saveToEEPROMButton1.Name = "saveToEEPROMButton1";
            this.saveToEEPROMButton1.Size = new System.Drawing.Size(90, 23);
            this.saveToEEPROMButton1.TabIndex = 5;
            this.saveToEEPROMButton1.Text = "Zapisz na stałe";
            this.saveToEEPROMButton1.UseVisualStyleBackColor = true;
            this.saveToEEPROMButton1.Click += new System.EventHandler(this.saveToEEPROMButton1_Click);
            // 
            // measurementTypeLabel
            // 
            this.measurementTypeLabel.AutoSize = true;
            this.measurementTypeLabel.Location = new System.Drawing.Point(10, 22);
            this.measurementTypeLabel.Name = "measurementTypeLabel";
            this.measurementTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.measurementTypeLabel.TabIndex = 4;
            this.measurementTypeLabel.Text = "Tryb pomiaru";
            // 
            // measurementTypeComboBox
            // 
            this.measurementTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.measurementTypeComboBox.Enabled = false;
            this.measurementTypeComboBox.FormattingEnabled = true;
            this.measurementTypeComboBox.Location = new System.Drawing.Point(7, 38);
            this.measurementTypeComboBox.Name = "measurementTypeComboBox";
            this.measurementTypeComboBox.Size = new System.Drawing.Size(80, 21);
            this.measurementTypeComboBox.TabIndex = 3;
            this.measurementTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.measurementTypeComboBox_SelectedIndexChanged);
            this.measurementTypeComboBox.DropDownClosed += new System.EventHandler(this.measurementTypeComboBox_DropDownClosed);
            this.measurementTypeComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.measurementTypeComboBox_MouseClick);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.Enabled = false;
            this.settingsButton.Location = new System.Drawing.Point(3, 407);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(91, 30);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Ustawienia";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(488, 407);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(93, 30);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // currentMeasurementBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.currentMeasurementBox, 4);
            this.currentMeasurementBox.Controls.Add(this.thicknessErrorValue);
            this.currentMeasurementBox.Controls.Add(this.thicknessErrorLabel);
            this.currentMeasurementBox.Controls.Add(this.thicknessValue);
            this.currentMeasurementBox.Controls.Add(this.thicknessLabel);
            this.currentMeasurementBox.Controls.Add(this.distanceErrorValue2);
            this.currentMeasurementBox.Controls.Add(this.distanceValue2);
            this.currentMeasurementBox.Controls.Add(this.intensityValue2);
            this.currentMeasurementBox.Controls.Add(this.distanceErrorLabel2);
            this.currentMeasurementBox.Controls.Add(this.distanceLabel2);
            this.currentMeasurementBox.Controls.Add(this.intensityLabel2);
            this.currentMeasurementBox.Controls.Add(this.distanceValue);
            this.currentMeasurementBox.Controls.Add(this.distanceErrorValue);
            this.currentMeasurementBox.Controls.Add(this.intensityValue);
            this.currentMeasurementBox.Controls.Add(this.distanceErrorLabel);
            this.currentMeasurementBox.Controls.Add(this.distanceLabel);
            this.currentMeasurementBox.Controls.Add(this.intensityLabel);
            this.currentMeasurementBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentMeasurementBox.Location = new System.Drawing.Point(100, 82);
            this.currentMeasurementBox.Name = "currentMeasurementBox";
            this.tableLayoutPanel1.SetRowSpan(this.currentMeasurementBox, 2);
            this.currentMeasurementBox.Size = new System.Drawing.Size(382, 152);
            this.currentMeasurementBox.TabIndex = 0;
            this.currentMeasurementBox.TabStop = false;
            this.currentMeasurementBox.Text = "Aktualny wynik pomiaru:";
            // 
            // thicknessErrorValue
            // 
            this.thicknessErrorValue.Location = new System.Drawing.Point(263, 124);
            this.thicknessErrorValue.Name = "thicknessErrorValue";
            this.thicknessErrorValue.ReadOnly = true;
            this.thicknessErrorValue.Size = new System.Drawing.Size(80, 20);
            this.thicknessErrorValue.TabIndex = 16;
            this.thicknessErrorValue.Visible = false;
            // 
            // thicknessErrorLabel
            // 
            this.thicknessErrorLabel.AutoSize = true;
            this.thicknessErrorLabel.Location = new System.Drawing.Point(260, 107);
            this.thicknessErrorLabel.Name = "thicknessErrorLabel";
            this.thicknessErrorLabel.Size = new System.Drawing.Size(98, 13);
            this.thicknessErrorLabel.TabIndex = 15;
            this.thicknessErrorLabel.Text = "Niepewność h [um]";
            this.thicknessErrorLabel.Visible = false;
            // 
            // thicknessValue
            // 
            this.thicknessValue.Location = new System.Drawing.Point(143, 124);
            this.thicknessValue.Name = "thicknessValue";
            this.thicknessValue.ReadOnly = true;
            this.thicknessValue.Size = new System.Drawing.Size(80, 20);
            this.thicknessValue.TabIndex = 14;
            this.thicknessValue.Visible = false;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(140, 107);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(79, 13);
            this.thicknessLabel.TabIndex = 13;
            this.thicknessLabel.Text = "Grubość h [um]";
            this.thicknessLabel.Visible = false;
            // 
            // distanceErrorValue2
            // 
            this.distanceErrorValue2.Location = new System.Drawing.Point(263, 79);
            this.distanceErrorValue2.Name = "distanceErrorValue2";
            this.distanceErrorValue2.ReadOnly = true;
            this.distanceErrorValue2.Size = new System.Drawing.Size(80, 20);
            this.distanceErrorValue2.TabIndex = 12;
            this.distanceErrorValue2.Visible = false;
            // 
            // distanceValue2
            // 
            this.distanceValue2.Location = new System.Drawing.Point(143, 79);
            this.distanceValue2.Name = "distanceValue2";
            this.distanceValue2.ReadOnly = true;
            this.distanceValue2.Size = new System.Drawing.Size(80, 20);
            this.distanceValue2.TabIndex = 11;
            this.distanceValue2.Visible = false;
            // 
            // intensityValue2
            // 
            this.intensityValue2.Location = new System.Drawing.Point(23, 79);
            this.intensityValue2.Name = "intensityValue2";
            this.intensityValue2.ReadOnly = true;
            this.intensityValue2.Size = new System.Drawing.Size(80, 20);
            this.intensityValue2.TabIndex = 10;
            this.intensityValue2.Visible = false;
            // 
            // distanceErrorLabel2
            // 
            this.distanceErrorLabel2.AutoSize = true;
            this.distanceErrorLabel2.Location = new System.Drawing.Point(260, 62);
            this.distanceErrorLabel2.Name = "distanceErrorLabel2";
            this.distanceErrorLabel2.Size = new System.Drawing.Size(104, 13);
            this.distanceErrorLabel2.TabIndex = 9;
            this.distanceErrorLabel2.Text = "Niepewność d2 [um]";
            this.distanceErrorLabel2.Visible = false;
            // 
            // distanceLabel2
            // 
            this.distanceLabel2.AutoSize = true;
            this.distanceLabel2.Location = new System.Drawing.Point(140, 62);
            this.distanceLabel2.Name = "distanceLabel2";
            this.distanceLabel2.Size = new System.Drawing.Size(94, 13);
            this.distanceLabel2.TabIndex = 8;
            this.distanceLabel2.Text = "Odległość d2 [um]";
            this.distanceLabel2.Visible = false;
            // 
            // intensityLabel2
            // 
            this.intensityLabel2.AutoSize = true;
            this.intensityLabel2.Location = new System.Drawing.Point(20, 62);
            this.intensityLabel2.Name = "intensityLabel2";
            this.intensityLabel2.Size = new System.Drawing.Size(84, 13);
            this.intensityLabel2.TabIndex = 7;
            this.intensityLabel2.Text = "Natężenie I2 [%]";
            this.intensityLabel2.Visible = false;
            // 
            // distanceValue
            // 
            this.distanceValue.Location = new System.Drawing.Point(143, 35);
            this.distanceValue.Name = "distanceValue";
            this.distanceValue.ReadOnly = true;
            this.distanceValue.Size = new System.Drawing.Size(80, 20);
            this.distanceValue.TabIndex = 6;
            // 
            // distanceErrorValue
            // 
            this.distanceErrorValue.Location = new System.Drawing.Point(263, 35);
            this.distanceErrorValue.Name = "distanceErrorValue";
            this.distanceErrorValue.ReadOnly = true;
            this.distanceErrorValue.Size = new System.Drawing.Size(80, 20);
            this.distanceErrorValue.TabIndex = 5;
            // 
            // intensityValue
            // 
            this.intensityValue.Location = new System.Drawing.Point(23, 35);
            this.intensityValue.Name = "intensityValue";
            this.intensityValue.ReadOnly = true;
            this.intensityValue.Size = new System.Drawing.Size(80, 20);
            this.intensityValue.TabIndex = 3;
            // 
            // distanceErrorLabel
            // 
            this.distanceErrorLabel.AutoSize = true;
            this.distanceErrorLabel.Location = new System.Drawing.Point(260, 19);
            this.distanceErrorLabel.Name = "distanceErrorLabel";
            this.distanceErrorLabel.Size = new System.Drawing.Size(104, 13);
            this.distanceErrorLabel.TabIndex = 2;
            this.distanceErrorLabel.Text = "Niepewność d1 [um]";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(140, 19);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(94, 13);
            this.distanceLabel.TabIndex = 1;
            this.distanceLabel.Text = "Odległość d1 [um]";
            // 
            // intensityLabel
            // 
            this.intensityLabel.AutoSize = true;
            this.intensityLabel.Location = new System.Drawing.Point(20, 19);
            this.intensityLabel.Name = "intensityLabel";
            this.intensityLabel.Size = new System.Drawing.Size(84, 13);
            this.intensityLabel.TabIndex = 0;
            this.intensityLabel.Text = "Natężenie I1 [%]";
            // 
            // multipleMeasurementButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.multipleMeasurementButton, 2);
            this.multipleMeasurementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.multipleMeasurementButton.Enabled = false;
            this.multipleMeasurementButton.Location = new System.Drawing.Point(197, 407);
            this.multipleMeasurementButton.Name = "multipleMeasurementButton";
            this.multipleMeasurementButton.Size = new System.Drawing.Size(188, 30);
            this.multipleMeasurementButton.TabIndex = 11;
            this.multipleMeasurementButton.Text = "Pomiar wielokrotny";
            this.multipleMeasurementButton.UseVisualStyleBackColor = true;
            this.multipleMeasurementButton.Click += new System.EventHandler(this.multipleMeasurementButton_Click);
            // 
            // portChoiceBox
            // 
            this.portChoiceBox.Controls.Add(this.portComboBox);
            this.portChoiceBox.Controls.Add(this.portNameLabel);
            this.portChoiceBox.Location = new System.Drawing.Point(197, 3);
            this.portChoiceBox.Name = "portChoiceBox";
            this.portChoiceBox.Size = new System.Drawing.Size(91, 73);
            this.portChoiceBox.TabIndex = 6;
            this.portChoiceBox.TabStop = false;
            this.portChoiceBox.Text = "Wybór portu:";
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(6, 38);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(80, 21);
            this.portComboBox.TabIndex = 6;
            this.portComboBox.SelectedIndexChanged += new System.EventHandler(this.portComboBox_SelectedIndexChanged);
            this.portComboBox.DropDownClosed += new System.EventHandler(this.portComboBox_DropDownClosed);
            this.portComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portComboBox_MouseClick);
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(9, 22);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(53, 13);
            this.portNameLabel.TabIndex = 5;
            this.portNameLabel.Text = "Port COM";
            // 
            // sampleTypeBox
            // 
            this.sampleTypeBox.Controls.Add(this.sampleComboBox);
            this.sampleTypeBox.Controls.Add(this.sampleTypeLabel);
            this.sampleTypeBox.Location = new System.Drawing.Point(294, 3);
            this.sampleTypeBox.Name = "sampleTypeBox";
            this.sampleTypeBox.Size = new System.Drawing.Size(91, 73);
            this.sampleTypeBox.TabIndex = 7;
            this.sampleTypeBox.TabStop = false;
            this.sampleTypeBox.Text = "Typ próbki:";
            // 
            // sampleComboBox
            // 
            this.sampleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampleComboBox.Enabled = false;
            this.sampleComboBox.FormattingEnabled = true;
            this.sampleComboBox.Location = new System.Drawing.Point(6, 38);
            this.sampleComboBox.Name = "sampleComboBox";
            this.sampleComboBox.Size = new System.Drawing.Size(80, 21);
            this.sampleComboBox.TabIndex = 2;
            this.sampleComboBox.SelectedIndexChanged += new System.EventHandler(this.sampleComboBox_SelectedIndexChanged);
            this.sampleComboBox.DropDownClosed += new System.EventHandler(this.sampleComboBox_DropDownClosed);
            this.sampleComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sampleComboBox_MouseClick);
            // 
            // sampleTypeLabel
            // 
            this.sampleTypeLabel.AutoSize = true;
            this.sampleTypeLabel.Location = new System.Drawing.Point(9, 22);
            this.sampleTypeLabel.Name = "sampleTypeLabel";
            this.sampleTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.sampleTypeLabel.TabIndex = 1;
            this.sampleTypeLabel.Text = "Próbka";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // darkSpectrumGroupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.darkSpectrumGroupBox, 2);
            this.darkSpectrumGroupBox.Controls.Add(this.standardDarkRadioButton);
            this.darkSpectrumGroupBox.Controls.Add(this.fastDarkRadioButton);
            this.darkSpectrumGroupBox.Controls.Add(this.calibrateDarkButton);
            this.darkSpectrumGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkSpectrumGroupBox.Location = new System.Drawing.Point(391, 3);
            this.darkSpectrumGroupBox.Name = "darkSpectrumGroupBox";
            this.darkSpectrumGroupBox.Size = new System.Drawing.Size(190, 73);
            this.darkSpectrumGroupBox.TabIndex = 12;
            this.darkSpectrumGroupBox.TabStop = false;
            this.darkSpectrumGroupBox.Text = "Kalibracja spektrum czerni:";
            this.darkSpectrumGroupBox.Enter += new System.EventHandler(this.darkSpectrumGroupBox_Enter);
            this.darkSpectrumGroupBox.Leave += new System.EventHandler(this.darkSpectrumGroupBox_Leave);
            // 
            // standardDarkRadioButton
            // 
            this.standardDarkRadioButton.AutoSize = true;
            this.standardDarkRadioButton.Location = new System.Drawing.Point(12, 39);
            this.standardDarkRadioButton.Name = "standardDarkRadioButton";
            this.standardDarkRadioButton.Size = new System.Drawing.Size(86, 17);
            this.standardDarkRadioButton.TabIndex = 4;
            this.standardDarkRadioButton.Text = "standardowa";
            this.standardDarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // fastDarkRadioButton
            // 
            this.fastDarkRadioButton.AutoSize = true;
            this.fastDarkRadioButton.Checked = true;
            this.fastDarkRadioButton.Location = new System.Drawing.Point(12, 20);
            this.fastDarkRadioButton.Name = "fastDarkRadioButton";
            this.fastDarkRadioButton.Size = new System.Drawing.Size(58, 17);
            this.fastDarkRadioButton.TabIndex = 3;
            this.fastDarkRadioButton.TabStop = true;
            this.fastDarkRadioButton.Text = "szybka";
            this.fastDarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // calibrateDarkButton
            // 
            this.calibrateDarkButton.Enabled = false;
            this.calibrateDarkButton.Location = new System.Drawing.Point(110, 36);
            this.calibrateDarkButton.Name = "calibrateDarkButton";
            this.calibrateDarkButton.Size = new System.Drawing.Size(75, 23);
            this.calibrateDarkButton.TabIndex = 2;
            this.calibrateDarkButton.Text = "Wykonaj";
            this.calibrateDarkButton.UseVisualStyleBackColor = true;
            this.calibrateDarkButton.Click += new System.EventHandler(this.calibrateDarkButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // settingsTimer1
            // 
            this.settingsTimer1.Interval = 200;
            this.settingsTimer1.Tick += new System.EventHandler(this.settingsTimer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "optoNCDT 2400 - Aplikacja dla użytkownika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.measurementTypeGroupBox.ResumeLayout(false);
            this.measurementTypeGroupBox.PerformLayout();
            this.currentMeasurementBox.ResumeLayout(false);
            this.currentMeasurementBox.PerformLayout();
            this.portChoiceBox.ResumeLayout(false);
            this.portChoiceBox.PerformLayout();
            this.sampleTypeBox.ResumeLayout(false);
            this.sampleTypeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkSpectrumGroupBox.ResumeLayout(false);
            this.darkSpectrumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox currentMeasurementBox;
        private System.Windows.Forms.Label distanceErrorLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label intensityLabel;
        private System.Windows.Forms.TextBox distanceErrorValue;
        private System.Windows.Forms.TextBox intensityValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox information;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.GroupBox portChoiceBox;
        private System.Windows.Forms.TextBox distanceValue;
        private System.Windows.Forms.GroupBox sampleTypeBox;
        private System.Windows.Forms.Label sampleTypeLabel;
        private System.Windows.Forms.ComboBox sampleComboBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.GroupBox measurementTypeGroupBox;
        private System.Windows.Forms.ComboBox measurementTypeComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.TextBox thicknessValue;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.TextBox distanceErrorValue2;
        private System.Windows.Forms.TextBox distanceValue2;
        private System.Windows.Forms.TextBox intensityValue2;
        private System.Windows.Forms.Label distanceErrorLabel2;
        private System.Windows.Forms.Label distanceLabel2;
        private System.Windows.Forms.Label intensityLabel2;
        private System.Windows.Forms.Button multipleMeasurementButton;
        private System.Windows.Forms.Label measurementTypeLabel;
        private System.Windows.Forms.GroupBox darkSpectrumGroupBox;
        private System.Windows.Forms.Button calibrateDarkButton;
        private System.Windows.Forms.RadioButton standardDarkRadioButton;
        private System.Windows.Forms.RadioButton fastDarkRadioButton;
        private System.Windows.Forms.Timer settingsTimer1;
        private System.Windows.Forms.Button saveToEEPROMButton1;
        private System.Windows.Forms.Label currentMeasurementTypeLabel;
        private System.Windows.Forms.TextBox thicknessErrorValue;
        private System.Windows.Forms.Label thicknessErrorLabel;
    }
}

