namespace Projekt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.settingsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.controllerSoftwareLabel = new System.Windows.Forms.Label();
            this.dspSoftwareLabel = new System.Windows.Forms.Label();
            this.controllerSoftwareTextBox = new System.Windows.Forms.TextBox();
            this.dspSoftwareTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.softwareLabel = new System.Windows.Forms.Label();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.sensorChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.currentSensorLabel = new System.Windows.Forms.Label();
            this.sensorTypeLabel = new System.Windows.Forms.Label();
            this.fullScaleValue = new System.Windows.Forms.TextBox();
            this.referenceDistanceValue = new System.Windows.Forms.TextBox();
            this.referenceDistanceLabel = new System.Windows.Forms.Label();
            this.fullScaleLabel = new System.Windows.Forms.Label();
            this.sensorChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.measurementSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.currentDetectionTresholdLabel = new System.Windows.Forms.Label();
            this.currentSamplingRateLabel = new System.Windows.Forms.Label();
            this.currentSpectralAveragingLabel = new System.Windows.Forms.Label();
            this.currentAveragingLabel = new System.Windows.Forms.Label();
            this.thrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sraComboBox = new System.Windows.Forms.ComboBox();
            this.avsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.avrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.thrLabel = new System.Windows.Forms.Label();
            this.sraLabel = new System.Windows.Forms.Label();
            this.avsLabel = new System.Windows.Forms.Label();
            this.avrLabel = new System.Windows.Forms.Label();
            this.type2And3SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.bracketedModeCheckBox = new System.Windows.Forms.CheckBox();
            this.currentRightDetectionLimitLabel = new System.Windows.Forms.Label();
            this.rightDetectionLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.leftDetectionLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentLeftDetectionLimitLabel = new System.Windows.Forms.Label();
            this.rightDetectionLimitLabel = new System.Windows.Forms.Label();
            this.leftDetectionLimitLabel = new System.Windows.Forms.Label();
            this.currentRefractiveIndexLabel = new System.Windows.Forms.Label();
            this.sriLabel = new System.Windows.Forms.Label();
            this.sriNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.closeSettingsButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.saveToEEPROMButton2 = new System.Windows.Forms.Button();
            this.settingsTimer2 = new System.Windows.Forms.Timer(this.components);
            this.settingsLayoutPanel.SuspendLayout();
            this.generalInfoGroupBox.SuspendLayout();
            this.sensorChoiceGroupBox.SuspendLayout();
            this.measurementSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrNumericUpDown)).BeginInit();
            this.type2And3SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightDetectionLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDetectionLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLayoutPanel
            // 
            this.settingsLayoutPanel.ColumnCount = 4;
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsLayoutPanel.Controls.Add(this.generalInfoGroupBox, 0, 0);
            this.settingsLayoutPanel.Controls.Add(this.sensorChoiceGroupBox, 0, 1);
            this.settingsLayoutPanel.Controls.Add(this.measurementSettingsGroupBox, 0, 2);
            this.settingsLayoutPanel.Controls.Add(this.type2And3SettingsGroupBox, 2, 2);
            this.settingsLayoutPanel.Controls.Add(this.closeSettingsButton, 3, 5);
            this.settingsLayoutPanel.Controls.Add(this.applyButton, 0, 5);
            this.settingsLayoutPanel.Controls.Add(this.saveToEEPROMButton2, 1, 5);
            this.settingsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsLayoutPanel.Name = "settingsLayoutPanel";
            this.settingsLayoutPanel.RowCount = 6;
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.settingsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.settingsLayoutPanel.Size = new System.Drawing.Size(584, 441);
            this.settingsLayoutPanel.TabIndex = 0;
            // 
            // generalInfoGroupBox
            // 
            this.settingsLayoutPanel.SetColumnSpan(this.generalInfoGroupBox, 4);
            this.generalInfoGroupBox.Controls.Add(this.controllerSoftwareLabel);
            this.generalInfoGroupBox.Controls.Add(this.dspSoftwareLabel);
            this.generalInfoGroupBox.Controls.Add(this.controllerSoftwareTextBox);
            this.generalInfoGroupBox.Controls.Add(this.dspSoftwareTextBox);
            this.generalInfoGroupBox.Controls.Add(this.serialNumberTextBox);
            this.generalInfoGroupBox.Controls.Add(this.softwareLabel);
            this.generalInfoGroupBox.Controls.Add(this.serialNumberLabel);
            this.generalInfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.generalInfoGroupBox.Name = "generalInfoGroupBox";
            this.generalInfoGroupBox.Size = new System.Drawing.Size(578, 82);
            this.generalInfoGroupBox.TabIndex = 0;
            this.generalInfoGroupBox.TabStop = false;
            this.generalInfoGroupBox.Text = "Informacje ogólne:";
            // 
            // controllerSoftwareLabel
            // 
            this.controllerSoftwareLabel.AutoSize = true;
            this.controllerSoftwareLabel.Location = new System.Drawing.Point(131, 49);
            this.controllerSoftwareLabel.Name = "controllerSoftwareLabel";
            this.controllerSoftwareLabel.Size = new System.Drawing.Size(60, 13);
            this.controllerSoftwareLabel.TabIndex = 6;
            this.controllerSoftwareLabel.Text = "- kontrolera";
            // 
            // dspSoftwareLabel
            // 
            this.dspSoftwareLabel.AutoSize = true;
            this.dspSoftwareLabel.Location = new System.Drawing.Point(328, 49);
            this.dspSoftwareLabel.Name = "dspSoftwareLabel";
            this.dspSoftwareLabel.Size = new System.Drawing.Size(71, 13);
            this.dspSoftwareLabel.TabIndex = 5;
            this.dspSoftwareLabel.Text = "- układu CPS";
            // 
            // controllerSoftwareTextBox
            // 
            this.controllerSoftwareTextBox.Location = new System.Drawing.Point(198, 46);
            this.controllerSoftwareTextBox.Name = "controllerSoftwareTextBox";
            this.controllerSoftwareTextBox.ReadOnly = true;
            this.controllerSoftwareTextBox.Size = new System.Drawing.Size(120, 20);
            this.controllerSoftwareTextBox.TabIndex = 4;
            // 
            // dspSoftwareTextBox
            // 
            this.dspSoftwareTextBox.Location = new System.Drawing.Point(406, 46);
            this.dspSoftwareTextBox.Name = "dspSoftwareTextBox";
            this.dspSoftwareTextBox.ReadOnly = true;
            this.dspSoftwareTextBox.Size = new System.Drawing.Size(120, 20);
            this.dspSoftwareTextBox.TabIndex = 3;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(126, 23);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.ReadOnly = true;
            this.serialNumberTextBox.Size = new System.Drawing.Size(400, 20);
            this.serialNumberTextBox.TabIndex = 2;
            // 
            // softwareLabel
            // 
            this.softwareLabel.AutoSize = true;
            this.softwareLabel.Location = new System.Drawing.Point(13, 49);
            this.softwareLabel.Name = "softwareLabel";
            this.softwareLabel.Size = new System.Drawing.Size(90, 13);
            this.softwareLabel.TabIndex = 1;
            this.softwareLabel.Text = "Oprogramowanie:";
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.AutoSize = true;
            this.serialNumberLabel.Location = new System.Drawing.Point(13, 23);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.serialNumberLabel.TabIndex = 0;
            this.serialNumberLabel.Text = "Numer seryjny:";
            // 
            // sensorChoiceGroupBox
            // 
            this.settingsLayoutPanel.SetColumnSpan(this.sensorChoiceGroupBox, 4);
            this.sensorChoiceGroupBox.Controls.Add(this.currentSensorLabel);
            this.sensorChoiceGroupBox.Controls.Add(this.sensorTypeLabel);
            this.sensorChoiceGroupBox.Controls.Add(this.fullScaleValue);
            this.sensorChoiceGroupBox.Controls.Add(this.referenceDistanceValue);
            this.sensorChoiceGroupBox.Controls.Add(this.referenceDistanceLabel);
            this.sensorChoiceGroupBox.Controls.Add(this.fullScaleLabel);
            this.sensorChoiceGroupBox.Controls.Add(this.sensorChoiceComboBox);
            this.sensorChoiceGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChoiceGroupBox.Location = new System.Drawing.Point(3, 91);
            this.sensorChoiceGroupBox.Name = "sensorChoiceGroupBox";
            this.sensorChoiceGroupBox.Size = new System.Drawing.Size(578, 82);
            this.sensorChoiceGroupBox.TabIndex = 1;
            this.sensorChoiceGroupBox.TabStop = false;
            this.sensorChoiceGroupBox.Text = "Wybór głowicy (czujnika):";
            // 
            // currentSensorLabel
            // 
            this.currentSensorLabel.AutoSize = true;
            this.currentSensorLabel.Location = new System.Drawing.Point(179, 49);
            this.currentSensorLabel.Name = "currentSensorLabel";
            this.currentSensorLabel.Size = new System.Drawing.Size(57, 13);
            this.currentSensorLabel.TabIndex = 6;
            this.currentSensorLabel.Text = "Aktualnie: ";
            // 
            // sensorTypeLabel
            // 
            this.sensorTypeLabel.AutoSize = true;
            this.sensorTypeLabel.Location = new System.Drawing.Point(10, 23);
            this.sensorTypeLabel.Name = "sensorTypeLabel";
            this.sensorTypeLabel.Size = new System.Drawing.Size(135, 13);
            this.sensorTypeLabel.TabIndex = 5;
            this.sensorTypeLabel.Text = "Dostępne głowice(czujniki)";
            // 
            // fullScaleValue
            // 
            this.fullScaleValue.Location = new System.Drawing.Point(466, 46);
            this.fullScaleValue.Name = "fullScaleValue";
            this.fullScaleValue.ReadOnly = true;
            this.fullScaleValue.Size = new System.Drawing.Size(60, 20);
            this.fullScaleValue.TabIndex = 4;
            // 
            // referenceDistanceValue
            // 
            this.referenceDistanceValue.Location = new System.Drawing.Point(466, 20);
            this.referenceDistanceValue.Name = "referenceDistanceValue";
            this.referenceDistanceValue.ReadOnly = true;
            this.referenceDistanceValue.Size = new System.Drawing.Size(60, 20);
            this.referenceDistanceValue.TabIndex = 3;
            // 
            // referenceDistanceLabel
            // 
            this.referenceDistanceLabel.AutoSize = true;
            this.referenceDistanceLabel.Location = new System.Drawing.Point(305, 23);
            this.referenceDistanceLabel.Name = "referenceDistanceLabel";
            this.referenceDistanceLabel.Size = new System.Drawing.Size(127, 13);
            this.referenceDistanceLabel.TabIndex = 2;
            this.referenceDistanceLabel.Text = "Minimalna odległość [um]";
            // 
            // fullScaleLabel
            // 
            this.fullScaleLabel.AutoSize = true;
            this.fullScaleLabel.Location = new System.Drawing.Point(305, 49);
            this.fullScaleLabel.Name = "fullScaleLabel";
            this.fullScaleLabel.Size = new System.Drawing.Size(116, 13);
            this.fullScaleLabel.TabIndex = 1;
            this.fullScaleLabel.Text = "Zakres pomiarowy [um]";
            // 
            // sensorChoiceComboBox
            // 
            this.sensorChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorChoiceComboBox.FormattingEnabled = true;
            this.sensorChoiceComboBox.Location = new System.Drawing.Point(13, 45);
            this.sensorChoiceComboBox.Name = "sensorChoiceComboBox";
            this.sensorChoiceComboBox.Size = new System.Drawing.Size(160, 21);
            this.sensorChoiceComboBox.TabIndex = 0;
            this.sensorChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.sensorChoiceComboBox_SelectedIndexChanged);
            // 
            // measurementSettingsGroupBox
            // 
            this.settingsLayoutPanel.SetColumnSpan(this.measurementSettingsGroupBox, 2);
            this.measurementSettingsGroupBox.Controls.Add(this.currentDetectionTresholdLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.currentSamplingRateLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.currentSpectralAveragingLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.currentAveragingLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.thrNumericUpDown);
            this.measurementSettingsGroupBox.Controls.Add(this.sraComboBox);
            this.measurementSettingsGroupBox.Controls.Add(this.avsNumericUpDown);
            this.measurementSettingsGroupBox.Controls.Add(this.avrNumericUpDown);
            this.measurementSettingsGroupBox.Controls.Add(this.thrLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.sraLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.avsLabel);
            this.measurementSettingsGroupBox.Controls.Add(this.avrLabel);
            this.measurementSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measurementSettingsGroupBox.Location = new System.Drawing.Point(3, 179);
            this.measurementSettingsGroupBox.Name = "measurementSettingsGroupBox";
            this.settingsLayoutPanel.SetRowSpan(this.measurementSettingsGroupBox, 2);
            this.measurementSettingsGroupBox.Size = new System.Drawing.Size(286, 134);
            this.measurementSettingsGroupBox.TabIndex = 2;
            this.measurementSettingsGroupBox.TabStop = false;
            this.measurementSettingsGroupBox.Text = "Ustawienia parametrów pomiaru:";
            // 
            // currentDetectionTresholdLabel
            // 
            this.currentDetectionTresholdLabel.AutoSize = true;
            this.currentDetectionTresholdLabel.Location = new System.Drawing.Point(234, 94);
            this.currentDetectionTresholdLabel.Name = "currentDetectionTresholdLabel";
            this.currentDetectionTresholdLabel.Size = new System.Drawing.Size(25, 13);
            this.currentDetectionTresholdLabel.TabIndex = 13;
            this.currentDetectionTresholdLabel.Text = "- - - ";
            // 
            // currentSamplingRateLabel
            // 
            this.currentSamplingRateLabel.AutoSize = true;
            this.currentSamplingRateLabel.Location = new System.Drawing.Point(234, 71);
            this.currentSamplingRateLabel.Name = "currentSamplingRateLabel";
            this.currentSamplingRateLabel.Size = new System.Drawing.Size(25, 13);
            this.currentSamplingRateLabel.TabIndex = 12;
            this.currentSamplingRateLabel.Text = "- - - ";
            // 
            // currentSpectralAveragingLabel
            // 
            this.currentSpectralAveragingLabel.AutoSize = true;
            this.currentSpectralAveragingLabel.Location = new System.Drawing.Point(234, 47);
            this.currentSpectralAveragingLabel.Name = "currentSpectralAveragingLabel";
            this.currentSpectralAveragingLabel.Size = new System.Drawing.Size(25, 13);
            this.currentSpectralAveragingLabel.TabIndex = 11;
            this.currentSpectralAveragingLabel.Text = "- - - ";
            // 
            // currentAveragingLabel
            // 
            this.currentAveragingLabel.AutoSize = true;
            this.currentAveragingLabel.Location = new System.Drawing.Point(234, 24);
            this.currentAveragingLabel.Name = "currentAveragingLabel";
            this.currentAveragingLabel.Size = new System.Drawing.Size(25, 13);
            this.currentAveragingLabel.TabIndex = 10;
            this.currentAveragingLabel.Text = "- - - ";
            // 
            // thrNumericUpDown
            // 
            this.thrNumericUpDown.Location = new System.Drawing.Point(158, 92);
            this.thrNumericUpDown.Maximum = new decimal(new int[] {
            4094,
            0,
            0,
            0});
            this.thrNumericUpDown.Name = "thrNumericUpDown";
            this.thrNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.thrNumericUpDown.TabIndex = 9;
            // 
            // sraComboBox
            // 
            this.sraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sraComboBox.FormattingEnabled = true;
            this.sraComboBox.Location = new System.Drawing.Point(158, 68);
            this.sraComboBox.Name = "sraComboBox";
            this.sraComboBox.Size = new System.Drawing.Size(60, 21);
            this.sraComboBox.TabIndex = 7;
            // 
            // avsNumericUpDown
            // 
            this.avsNumericUpDown.Location = new System.Drawing.Point(158, 45);
            this.avsNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.avsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avsNumericUpDown.Name = "avsNumericUpDown";
            this.avsNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.avsNumericUpDown.TabIndex = 6;
            this.avsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // avrNumericUpDown
            // 
            this.avrNumericUpDown.Location = new System.Drawing.Point(158, 22);
            this.avrNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.avrNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.avrNumericUpDown.Name = "avrNumericUpDown";
            this.avrNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.avrNumericUpDown.TabIndex = 5;
            this.avrNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // thrLabel
            // 
            this.thrLabel.AutoSize = true;
            this.thrLabel.Location = new System.Drawing.Point(10, 94);
            this.thrLabel.Name = "thrLabel";
            this.thrLabel.Size = new System.Drawing.Size(69, 13);
            this.thrLabel.TabIndex = 4;
            this.thrLabel.Text = "Próg detekcji";
            // 
            // sraLabel
            // 
            this.sraLabel.AutoSize = true;
            this.sraLabel.Location = new System.Drawing.Point(10, 71);
            this.sraLabel.Name = "sraLabel";
            this.sraLabel.Size = new System.Drawing.Size(135, 13);
            this.sraLabel.TabIndex = 2;
            this.sraLabel.Text = "Częstotliwość próbkowania";
            // 
            // avsLabel
            // 
            this.avsLabel.AutoSize = true;
            this.avsLabel.Location = new System.Drawing.Point(10, 47);
            this.avsLabel.Name = "avsLabel";
            this.avsLabel.Size = new System.Drawing.Size(115, 13);
            this.avsLabel.TabIndex = 1;
            this.avsLabel.Text = "Uśrednianie spektralne";
            // 
            // avrLabel
            // 
            this.avrLabel.AutoSize = true;
            this.avrLabel.Location = new System.Drawing.Point(10, 24);
            this.avrLabel.Name = "avrLabel";
            this.avrLabel.Size = new System.Drawing.Size(63, 13);
            this.avrLabel.TabIndex = 0;
            this.avrLabel.Text = "Uśrednianie";
            // 
            // type2And3SettingsGroupBox
            // 
            this.settingsLayoutPanel.SetColumnSpan(this.type2And3SettingsGroupBox, 2);
            this.type2And3SettingsGroupBox.Controls.Add(this.bracketedModeCheckBox);
            this.type2And3SettingsGroupBox.Controls.Add(this.currentRightDetectionLimitLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.rightDetectionLimitNumericUpDown);
            this.type2And3SettingsGroupBox.Controls.Add(this.leftDetectionLimitNumericUpDown);
            this.type2And3SettingsGroupBox.Controls.Add(this.currentLeftDetectionLimitLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.rightDetectionLimitLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.leftDetectionLimitLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.currentRefractiveIndexLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.sriLabel);
            this.type2And3SettingsGroupBox.Controls.Add(this.sriNumericUpDown);
            this.type2And3SettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type2And3SettingsGroupBox.Location = new System.Drawing.Point(295, 179);
            this.type2And3SettingsGroupBox.Name = "type2And3SettingsGroupBox";
            this.settingsLayoutPanel.SetRowSpan(this.type2And3SettingsGroupBox, 2);
            this.type2And3SettingsGroupBox.Size = new System.Drawing.Size(286, 134);
            this.type2And3SettingsGroupBox.TabIndex = 9;
            this.type2And3SettingsGroupBox.TabStop = false;
            this.type2And3SettingsGroupBox.Text = "Ustawienia dla trybów pomiaru 1 i 2:";
            // 
            // bracketedModeCheckBox
            // 
            this.bracketedModeCheckBox.AutoSize = true;
            this.bracketedModeCheckBox.Location = new System.Drawing.Point(16, 94);
            this.bracketedModeCheckBox.Name = "bracketedModeCheckBox";
            this.bracketedModeCheckBox.Size = new System.Drawing.Size(155, 17);
            this.bracketedModeCheckBox.TabIndex = 16;
            this.bracketedModeCheckBox.Text = "Limity detekcji nałożone (2)";
            this.bracketedModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // currentRightDetectionLimitLabel
            // 
            this.currentRightDetectionLimitLabel.AutoSize = true;
            this.currentRightDetectionLimitLabel.Location = new System.Drawing.Point(239, 71);
            this.currentRightDetectionLimitLabel.Name = "currentRightDetectionLimitLabel";
            this.currentRightDetectionLimitLabel.Size = new System.Drawing.Size(25, 13);
            this.currentRightDetectionLimitLabel.TabIndex = 15;
            this.currentRightDetectionLimitLabel.Text = "- - - ";
            // 
            // rightDetectionLimitNumericUpDown
            // 
            this.rightDetectionLimitNumericUpDown.Location = new System.Drawing.Point(161, 68);
            this.rightDetectionLimitNumericUpDown.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.rightDetectionLimitNumericUpDown.Name = "rightDetectionLimitNumericUpDown";
            this.rightDetectionLimitNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.rightDetectionLimitNumericUpDown.TabIndex = 14;
            // 
            // leftDetectionLimitNumericUpDown
            // 
            this.leftDetectionLimitNumericUpDown.Location = new System.Drawing.Point(161, 45);
            this.leftDetectionLimitNumericUpDown.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.leftDetectionLimitNumericUpDown.Name = "leftDetectionLimitNumericUpDown";
            this.leftDetectionLimitNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.leftDetectionLimitNumericUpDown.TabIndex = 13;
            // 
            // currentLeftDetectionLimitLabel
            // 
            this.currentLeftDetectionLimitLabel.AutoSize = true;
            this.currentLeftDetectionLimitLabel.Location = new System.Drawing.Point(239, 47);
            this.currentLeftDetectionLimitLabel.Name = "currentLeftDetectionLimitLabel";
            this.currentLeftDetectionLimitLabel.Size = new System.Drawing.Size(25, 13);
            this.currentLeftDetectionLimitLabel.TabIndex = 12;
            this.currentLeftDetectionLimitLabel.Text = "- - - ";
            // 
            // rightDetectionLimitLabel
            // 
            this.rightDetectionLimitLabel.AutoSize = true;
            this.rightDetectionLimitLabel.Location = new System.Drawing.Point(13, 71);
            this.rightDetectionLimitLabel.Name = "rightDetectionLimitLabel";
            this.rightDetectionLimitLabel.Size = new System.Drawing.Size(111, 13);
            this.rightDetectionLimitLabel.TabIndex = 11;
            this.rightDetectionLimitLabel.Text = "Prawy limit detekcji (2)";
            // 
            // leftDetectionLimitLabel
            // 
            this.leftDetectionLimitLabel.AutoSize = true;
            this.leftDetectionLimitLabel.Location = new System.Drawing.Point(13, 47);
            this.leftDetectionLimitLabel.Name = "leftDetectionLimitLabel";
            this.leftDetectionLimitLabel.Size = new System.Drawing.Size(107, 13);
            this.leftDetectionLimitLabel.TabIndex = 10;
            this.leftDetectionLimitLabel.Text = "Lewy limit detekcji (2)";
            // 
            // currentRefractiveIndexLabel
            // 
            this.currentRefractiveIndexLabel.AutoSize = true;
            this.currentRefractiveIndexLabel.Location = new System.Drawing.Point(239, 24);
            this.currentRefractiveIndexLabel.Name = "currentRefractiveIndexLabel";
            this.currentRefractiveIndexLabel.Size = new System.Drawing.Size(25, 13);
            this.currentRefractiveIndexLabel.TabIndex = 9;
            this.currentRefractiveIndexLabel.Text = "- - - ";
            // 
            // sriLabel
            // 
            this.sriLabel.AutoSize = true;
            this.sriLabel.Location = new System.Drawing.Point(13, 24);
            this.sriLabel.Name = "sriLabel";
            this.sriLabel.Size = new System.Drawing.Size(127, 13);
            this.sriLabel.TabIndex = 3;
            this.sriLabel.Text = "Współczynnik załamania";
            // 
            // sriNumericUpDown
            // 
            this.sriNumericUpDown.DecimalPlaces = 3;
            this.sriNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.sriNumericUpDown.Location = new System.Drawing.Point(161, 22);
            this.sriNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sriNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sriNumericUpDown.Name = "sriNumericUpDown";
            this.sriNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.sriNumericUpDown.TabIndex = 8;
            this.sriNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // closeSettingsButton
            // 
            this.closeSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeSettingsButton.Location = new System.Drawing.Point(441, 380);
            this.closeSettingsButton.Name = "closeSettingsButton";
            this.closeSettingsButton.Size = new System.Drawing.Size(140, 30);
            this.closeSettingsButton.TabIndex = 4;
            this.closeSettingsButton.Text = "Zamknij";
            this.closeSettingsButton.UseVisualStyleBackColor = true;
            this.closeSettingsButton.Click += new System.EventHandler(this.closeSettingsButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.applyButton.Location = new System.Drawing.Point(3, 380);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(140, 30);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Zastosuj";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // saveToEEPROMButton2
            // 
            this.saveToEEPROMButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveToEEPROMButton2.Location = new System.Drawing.Point(149, 380);
            this.saveToEEPROMButton2.Name = "saveToEEPROMButton2";
            this.saveToEEPROMButton2.Size = new System.Drawing.Size(140, 30);
            this.saveToEEPROMButton2.TabIndex = 10;
            this.saveToEEPROMButton2.Text = "Zapisz na stałe";
            this.saveToEEPROMButton2.UseVisualStyleBackColor = true;
            this.saveToEEPROMButton2.Click += new System.EventHandler(this.saveToEEPROMButton2_Click);
            // 
            // settingsTimer2
            // 
            this.settingsTimer2.Interval = 200;
            this.settingsTimer2.Tick += new System.EventHandler(this.settingsTimer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.settingsLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "optoNCDT 2400 - Ustawienia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.settingsLayoutPanel.ResumeLayout(false);
            this.generalInfoGroupBox.ResumeLayout(false);
            this.generalInfoGroupBox.PerformLayout();
            this.sensorChoiceGroupBox.ResumeLayout(false);
            this.sensorChoiceGroupBox.PerformLayout();
            this.measurementSettingsGroupBox.ResumeLayout(false);
            this.measurementSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrNumericUpDown)).EndInit();
            this.type2And3SettingsGroupBox.ResumeLayout(false);
            this.type2And3SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightDetectionLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftDetectionLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel settingsLayoutPanel;
        private System.Windows.Forms.GroupBox generalInfoGroupBox;
        private System.Windows.Forms.GroupBox sensorChoiceGroupBox;
        private System.Windows.Forms.ComboBox sensorChoiceComboBox;
        private System.Windows.Forms.GroupBox measurementSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown thrNumericUpDown;
        private System.Windows.Forms.NumericUpDown sriNumericUpDown;
        private System.Windows.Forms.ComboBox sraComboBox;
        private System.Windows.Forms.NumericUpDown avsNumericUpDown;
        private System.Windows.Forms.NumericUpDown avrNumericUpDown;
        private System.Windows.Forms.Label thrLabel;
        private System.Windows.Forms.Label sriLabel;
        private System.Windows.Forms.Label sraLabel;
        private System.Windows.Forms.Label avsLabel;
        private System.Windows.Forms.Label avrLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button closeSettingsButton;
        private System.Windows.Forms.Label referenceDistanceLabel;
        private System.Windows.Forms.Label fullScaleLabel;
        private System.Windows.Forms.Label sensorTypeLabel;
        private System.Windows.Forms.TextBox fullScaleValue;
        private System.Windows.Forms.TextBox referenceDistanceValue;
        private System.Windows.Forms.GroupBox type2And3SettingsGroupBox;
        private System.Windows.Forms.Label currentSensorLabel;
        private System.Windows.Forms.Label currentDetectionTresholdLabel;
        private System.Windows.Forms.Label currentSamplingRateLabel;
        private System.Windows.Forms.Label currentSpectralAveragingLabel;
        private System.Windows.Forms.Label currentAveragingLabel;
        private System.Windows.Forms.Label currentRefractiveIndexLabel;
        private System.Windows.Forms.NumericUpDown rightDetectionLimitNumericUpDown;
        private System.Windows.Forms.NumericUpDown leftDetectionLimitNumericUpDown;
        private System.Windows.Forms.Label currentLeftDetectionLimitLabel;
        private System.Windows.Forms.Label rightDetectionLimitLabel;
        private System.Windows.Forms.Label leftDetectionLimitLabel;
        private System.Windows.Forms.Label currentRightDetectionLimitLabel;
        private System.Windows.Forms.Timer settingsTimer2;
        private System.Windows.Forms.CheckBox bracketedModeCheckBox;
        private System.Windows.Forms.Button saveToEEPROMButton2;
        private System.Windows.Forms.TextBox dspSoftwareTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label softwareLabel;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.Label dspSoftwareLabel;
        private System.Windows.Forms.TextBox controllerSoftwareTextBox;
        private System.Windows.Forms.Label controllerSoftwareLabel;
    }
}