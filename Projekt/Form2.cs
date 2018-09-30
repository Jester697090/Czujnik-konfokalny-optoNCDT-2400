using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Projekt
{
    public partial class Form2 : Form
    {
        SerialPort serialPort1;
        Controller myController;
        Controller.Status myStatus;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(System.IO.Ports.SerialPort sp, Controller c, Controller.Status s)
        {
            serialPort1 = sp;
            myController = c;
            myStatus = s;

            InitializeComponent();
        }

        public void InitiallyUpdateAllFields2()
        {
            serialNumberTextBox.Text = myController.SerialNumber;
            controllerSoftwareTextBox.Text = myController.ControllerSoftware;
            dspSoftwareTextBox.Text = myController.DspSoftware;

            if (myController.SensorID >= 0 && myController.SensorID <= 5)
            {
                sensorChoiceComboBox.SelectedIndex = myController.SensorID;
            }

            if (new List<double> { 80, 350, 1000, 3000, 10000, 24000 }.Contains(myController.FullScale))
            {
                fullScaleValue.Text = myController.FullScale.ToString();
            }

            if (myController.Averaging >= 1 && myController.Averaging <= 999)
            {
                avrNumericUpDown.Value = myController.Averaging;
            }

            if (myController.SpectralAveraging >= 1 && myController.SpectralAveraging <= 99)
            {
                avsNumericUpDown.Value = myController.SpectralAveraging;
            }

            sraComboBox.SelectedIndex = Array.IndexOf(myController.SamplingRates, myController.SamplingRate) / 2;

            if (myController.DetectionTreshold >= 0 && myController.DetectionTreshold <= 4094)
            {
                thrNumericUpDown.Value = myController.DetectionTreshold;
            }

            if (myController.RefractiveIndex >= 1.000 && myController.RefractiveIndex <= 5.000)
            {
                sriNumericUpDown.Value = decimal.Parse(myController.RefractiveIndex.ToString());
            }

            if (myController.LeftDetectionLimit >= 0 && myController.LeftDetectionLimit <= 32767)
            {
                leftDetectionLimitNumericUpDown.Value = myController.LeftDetectionLimit;
            }

            if (myController.RightDetectionLimit >= 0 && myController.RightDetectionLimit <= 32767)
            {
                rightDetectionLimitNumericUpDown.Value = myController.RightDetectionLimit;
            }

            if (myStatus.bracketedModeChosen == true)
            {
                bracketedModeCheckBox.Checked = true;
            }
            else
            {
                bracketedModeCheckBox.Checked = false;
            }

        }

        public void UpdateAllFields2()
        {
            if (myController.SensorID >= 0 && myController.SensorID <= 5)
            {
                currentSensorLabel.Text = "Aktualnie: " + myController.SensorID.ToString();
            }

            fullScaleValue.Text = myController.FullScale.ToString();
            referenceDistanceValue.Text = myController.ChosenSensor.GetReferenceDistance().ToString();

            if (myController.Averaging >= 1 && myController.Averaging <= 999)
            {
                currentAveragingLabel.Text = myController.Averaging.ToString();
            }

            if (myController.SpectralAveraging >= 1 && myController.SpectralAveraging <= 99)
            {
                currentSpectralAveragingLabel.Text = myController.SpectralAveraging.ToString();
            }

            currentSamplingRateLabel.Text = myController.SamplingRate.ToString();

            if (myController.RefractiveIndex >= 1.000 && myController.RefractiveIndex <= 5.000)
            {
                currentRefractiveIndexLabel.Text = myController.RefractiveIndex.ToString("0.000");
            }

            if (myController.DetectionTreshold >= 0 && myController.DetectionTreshold <= 4094)
            {
                currentDetectionTresholdLabel.Text = myController.DetectionTreshold.ToString();
            }

            if (myController.LeftDetectionLimit >= 0 && myController.LeftDetectionLimit <= 32767)
            {
                currentLeftDetectionLimitLabel.Text = myController.LeftDetectionLimit.ToString();
            }

            if (myController.RightDetectionLimit >= 0 && myController.RightDetectionLimit <= 32767)
            {
                currentRightDetectionLimitLabel.Text = myController.RightDetectionLimit.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Zapełnienie sensorChoiceComboBox'u nazwami możliwych czujników
                       
            string [] sensorChoiceComboBoxContent = new string[myController.Sensors.Count];

            sensorChoiceComboBox.Items.Clear();

            for (int k = 0; k < myController.Sensors.Count; k++)
            {
                sensorChoiceComboBoxContent[k] = k.ToString() + " - " + myController.Sensors[k].GetName();
            }

            sensorChoiceComboBox.Items.AddRange(sensorChoiceComboBoxContent);

            // Zapełnienie sraComboBox'u możliwymi częstotliwościami próbkowania

            string [] sraComboBoxContent = new string [] { "30", "100", "300", "1000"};

            sraComboBox.Items.Clear();

            sraComboBox.Items.AddRange(sraComboBoxContent);

            // Wyświetlenie obecnych ustawień kontrolera

            InitiallyUpdateAllFields2();

            // Rozpoczęcie pomiaru czasu

            settingsTimer2.Enabled = true;

        }

        private void settingsTimer2_Tick(object sender, EventArgs e)
        {
            UpdateAllFields2();

            if (myStatus.areBasicSettingsSet == true)
            {
                return;
            }
            else
            {
                myStatus.VerifyIfBasicSettingsAreSet();
            }

            if (myStatus.areExtraSettingsSet == true)
            {
                return;
            }
            else
            {
                myStatus.VerifyIfExtraSettingsAreSet();
            }
        }

        private void sensorChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sensorChoiceComboBox.SelectedIndex == -1) return;

            myController.SensorID = sensorChoiceComboBox.SelectedIndex;
            myController.ChosenSensor = myController.Sensors[sensorChoiceComboBox.SelectedIndex];

            myStatus.basicSettingsList[3] = true;

            myController.FullScale = myController.ChosenSensor.GetMeasuringRange();

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }

            serialPort1.WriteLine("$SEN" + sensorChoiceComboBox.SelectedIndex.ToString());
            serialPort1.WriteLine("$SCA");
            serialPort1.WriteLine("$AVR" + avrNumericUpDown.Value.ToString());
            serialPort1.WriteLine("$AVS" + avsNumericUpDown.Value.ToString());
            serialPort1.WriteLine("$SRA" + myController.SamplingRates[Array.IndexOf(myController.SamplingRates, int.Parse(sraComboBox.Items[sraComboBox.SelectedIndex].ToString())) - 1]);
            serialPort1.WriteLine("$THR" + thrNumericUpDown.Value.ToString());

            serialPort1.WriteLine("$SRI" + sriNumericUpDown.Value.ToString());
            serialPort1.WriteLine("$LLM" + leftDetectionLimitNumericUpDown.Value.ToString());
            serialPort1.WriteLine("$RLM" + rightDetectionLimitNumericUpDown.Value.ToString());

            if (bracketedModeCheckBox.Checked == true)
            {
                serialPort1.WriteLine("$LMA" + "5");
            }
            else
            {
                serialPort1.WriteLine("$LMA" + "0");
            }

        }

        private void saveToEEPROMButton2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("$SSU");
        }

        private void closeSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.isSecondaryFormClosed = true;
        }



    }
}
