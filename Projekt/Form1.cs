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
    public partial class Form1 : Form
    {
        Object myLock = new Object();
        Controller myController = new Controller();
        ReplyService myReplyService = new ReplyService();

        string line;
        string [] results;

        List<String> portNames = new List<String>();

        bool measurementTypeComboBoxSelected = false;
        bool sampleComboBoxSelected = false;
        bool portComboBoxSelected = false;
        bool isDarkSpectrumGroupBoxEntered = false;

        Controller.Status myStatus = new Controller.Status();

        public static bool isMeasurementRunning = false;
        public static bool isSecondaryFormClosed = false;

        bool initialControlsSet = false;
        bool isMeasurementStopped = false;

        

        public Form1()
        {
            InitializeComponent();
        }


        private void SetDefaultInformation()
        {
            information.Text = "Witaj w Aplikacji użytkownika optoNCDT 2400. Instrukcje:" + Environment.NewLine;
            information.AppendText("1. Wybierz odpowiedni port COM." + Environment.NewLine);
            information.AppendText("2. Zmień (opcjonalnie) tryb pomiaru." + Environment.NewLine);
            information.AppendText("3. Wybierz typ próbki." + Environment.NewLine);
            information.AppendText("4. Upewnij się, że w Ustawieniach wybrane są odpowiednie warunki pomiaru." + Environment.NewLine);
            information.AppendText("5. Kliknij START, by rozpocząć pomiar i STOP, by go wstrzymać.");
        }

        private void SetDefaultPicture()
        {
            pictureBox1.Image = MyContent.info;
            pictureBox1.Refresh();
        }

        private void SetCorrectInformation()
        {
            pictureBox1.Image = MyContent.correct;
            pictureBox1.Refresh();

            information.Text = "Czujnik mierzy prawidłowo." + Environment.NewLine;
            information.AppendText(Environment.NewLine + "Przed zmianą ustawień należy wcisnąć STOP.");
        }

        private void SetWrongInformation()
        {
            pictureBox1.Image = MyContent.wrong;
            pictureBox1.Refresh();

            information.Text = "Czujnik nie mierzy prawidłowo. Możliwe, że:" + Environment.NewLine; // Environment.NewLine - znak nowej linii
            information.AppendText("1. Obiekt nie znajduje się w zasięgu pomiaru." + Environment.NewLine); // AppendText robi znak nowej linii automatycznie
            information.AppendText("2. Czujnik jest nieprawidłowo podłączony." + Environment.NewLine);
            information.AppendText("3. Częstotliwość próbkowania jest za duża dla danego obiektu." + Environment.NewLine);
            information.AppendText("4. Próg detekcji jest za wysoki." + Environment.NewLine);
            information.AppendText("5. Gniazdo światłowodu jest uszkodzone." + Environment.NewLine);
            information.AppendText(Environment.NewLine + "Przed zmianą ustawień należy wcisnąć STOP.");
        }

        private void SetHoldInformation()
        {
            pictureBox1.Image = MyContent.hold;
            pictureBox1.Refresh();

            information.Text = "Wstrzymano wykonywanie pomiaru. Aby wznowić pomiar, naciśnij ponownie START.";
        }

        public void GetSettingsFromController()
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }

            // Upewnienie się że dane transmitowane są w kodzie ASCII

            serialPort1.WriteLine("$ASC");

            // Wyświetlane w Formie 1

            serialPort1.WriteLine("$MOD?");

            // Wyświetlane w Formie 2

            serialPort1.WriteLine("$VER");

            serialPort1.WriteLine("$SEN?");
            serialPort1.WriteLine("$SCA");

            serialPort1.WriteLine("$AVR?");
            serialPort1.WriteLine("$AVS?");
            serialPort1.WriteLine("$SRA?");
            serialPort1.WriteLine("$THR?");

            serialPort1.WriteLine("$SRI?");
            serialPort1.WriteLine("$LLM?");
            serialPort1.WriteLine("$RLM?");
            serialPort1.WriteLine("$LMA?");

        }

        public void UpdateAllFields1()
        {
            if (myStatus.basicSettingsList[0] == true && initialControlsSet == false)
            {
                measurementTypeComboBox.SelectedIndex = myController.MeasurementType;
                initialControlsSet = true;
            }

            if (myStatus.basicSettingsList[1] == true)
            {
                currentMeasurementTypeLabel.Text = "Aktualnie: " + myController.MeasurementType.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // Zapełnienie measurementTypeComboBox'u możliwymi trybami pomiaru

            measurementTypeComboBox.Items.Clear();
            measurementTypeComboBox.Items.AddRange(myController.MeasurementTypes.ToArray());

            // Zabezpieczenie, by program nie przypisywał kontrolerowi domyślnej wartości int measurementType = 0

            myController.MeasurementType = -1;

            // Zapełnienie portComboBox'u możliwymi portami COM

            portComboBox.Items.Clear();

            foreach (string portName in SerialPort.GetPortNames())
            {
                portNames.Add(portName);
            }

            portNames.Sort();
            portComboBox.Items.AddRange(portNames.ToArray());

            // Zapełnienie sampleComboBox'u możliwymi rodzajami próbek

            sampleComboBox.Items.Clear();
            sampleComboBox.Items.AddRange(myController.SampleNames.ToArray());

            // Wyświetlenie komuniaktu początkowego (domyślnego)

            SetDefaultPicture();
            SetDefaultInformation();

            // Rozpoczęcie pomiaru czasu

            timer1.Enabled = true;
            settingsTimer1.Enabled = true;


        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            line = serialPort1.ReadLine();

            if (line.StartsWith("$")) // sprawdza, czy na port przyszło echo komendy i/lub odpowiedź ($...)
            {
                myReplyService.Order = line.Substring(0, 4);
                myReplyService.Line = line;

                switch (myReplyService.Order)
                {
                    case "$AVR":
                        myReplyService.ServeAVR();
                        myController.Averaging = int.Parse(myReplyService.Reply);
                        myStatus.basicSettingsList[4] = true;
                        break;
                    case "$AVS":
                        myReplyService.ServeAVS();
                        myController.SpectralAveraging = int.Parse(myReplyService.Reply);
                        myStatus.basicSettingsList[5] = true;
                        break;
                    case "$SRA":
                        myReplyService.ServeSRA(myController.SamplingRates);
                        myController.SamplingRate = int.Parse(myReplyService.Reply);
                        myStatus.basicSettingsList[6] = true;
                        break;
                    case "$MOD":
                        myReplyService.ServeMOD();
                        myController.MeasurementType = int.Parse(myReplyService.Reply);
                        myStatus.basicSettingsList[0] = true;
                        break;
                    case "$SEN":
                        myReplyService.ServeSEN();
                        myController.SensorID = int.Parse(myReplyService.Reply);
                        myController.ChosenSensor = myController.Sensors[myController.SensorID];
                        myStatus.basicSettingsList[3] = true;
                        break;
                    case "$ASC":
                        break;
                    case "$BIN":
                        break;
                    case "$DRK":
                        break;
                    case "$SCA":
                        myReplyService.ServeSCA();
                        myController.FullScale = double.Parse(myReplyService.Reply);
                        break;
                    case "$SRI":
                        myReplyService.ServeSRI();
                        myController.RefractiveIndex = double.Parse(myReplyService.Reply);
                        myStatus.extraSettingsList[0] = true;
                        break;
                    case "$TRG":
                        break;
                    case "$SOD":
                        break;
                    case "$ANA":
                        break;
                    case "$STS":
                        break;
                    case "$SSU": // kluczowy, by ustawienie było zapisane do EEPROM
                        break;
                    case "$VER":
                        myReplyService.ServeVER();
                        string [] replies = myReplyService.Reply.Split(';');
                        myController.SerialNumber = replies[0];
                        myController.ControllerSoftware = replies[1];
                        myController.DspSoftware = replies[2];
                        break;
                    case "$LOC":
                        break;
                    case "$FDK":
                        break;
                    case "$THR":
                        myReplyService.ServeTHR();
                        myController.DetectionTreshold = int.Parse(myReplyService.Reply);
                        myStatus.basicSettingsList[7] = true;
                        break;
                    case "$LLM":
                        myReplyService.ServeLLM();
                        myController.LeftDetectionLimit = int.Parse(myReplyService.Reply);
                        myStatus.extraSettingsList[1] = true;
                        break;
                    case "$RLM":
                        myReplyService.ServeRLM();
                        myController.RightDetectionLimit = int.Parse(myReplyService.Reply);
                        myStatus.extraSettingsList[2] = true;
                        break;
                    case "$LMA":
                        myReplyService.ServeLMA();

                        if (int.Parse(myReplyService.Reply) == 5)
                        {
                            myStatus.bracketedModeChosen = true;
                        }
                        else
                        {
                            myStatus.bracketedModeChosen = false;
                        }

                        break;
                    default:
                        break;

                }

                return;
            }

            else if (Char.IsDigit(line, 0) == true) // linia to nie echo i/lub odpowiedź, ale trzeba się upewnić, że to liczba, a nie coś innego!
            {
                // Blok obliczeniowy programu

                if (isMeasurementRunning == true && myStatus.areBasicSettingsSet == true)
                {
                    double tempDistance1;
                    double tempDistanceError1 = 0;
                    double tempIntensity1;

                    switch (myController.MeasurementType)
                    {
                        case 0:

                            results = line.Split(',');
                            results[results.Length - 1] = results[results.Length - 1].Remove(results[results.Length - 1].Length - 1);

                            // Optymalizacja - zaoszczędza czas spędzany w lock{}, dzięki obliczeniom poza instrukcją lock{}
                            // i przepisywaniu ich do zmiennych docelowych w lock{}, co trwa zdecydowanie krócej.

                            tempDistance1 = double.Parse(results[0]) / 32767 * myController.FullScale; // [um]
                            tempDistanceError1 = 0;

                            switch (myController.SampleType)
                            {
                                case 0:
                                    tempDistanceError1 = (0.002 + 0.00004) * myController.FullScale / Math.Sqrt(3); // [um], (niepewność) dla próbki dyfuzyjnej odbijającej
                                    break;
                                case 1:
                                    tempDistanceError1 = (0.0003 + 0.00004) * myController.FullScale / Math.Sqrt(3); // [um], (niepewność) dla próbki przezroczystej
                                    break;
                            }

                            tempIntensity1 = double.Parse(results[1]) / 4095 * 100; // [%]

                            lock (myLock)
                            {
                                myController.Distance1 = tempDistance1;
                                myController.DistanceError1 = tempDistanceError1;
                                myController.Intensity1 = tempIntensity1;
                            }

                            break;

                        case 1:
                            
                                double tempThickness;
                                double tempDistance2;
                                double tempDistanceError2 = 0;
                                double tempIntensity2;
                                double tempThicknessError;

                                results = line.Split(',');
                                results[results.Length - 1] = results[results.Length - 1].Remove(results[results.Length - 1].Length - 1);

                                // Optymalizacja - zaoszczędza czas spędzany w lock{}, dzięki obliczeniom poza instrukcją lock{}
                                // i przepisywaniu ich do zmiennych docelowych w lock{}, co trwa zdecydowanie krócej.

                                tempThickness = double.Parse(results[0]) / 32767 * myController.FullScale * myController.RefractiveIndex; // [um]
                                tempDistance1 = double.Parse(results[1]) / 32767 * myController.FullScale; // [um]
                                tempDistance2 = double.Parse(results[2]) / 32767 * myController.FullScale; // [um]

                                switch (myController.SampleType)
                                {
                                    case 0:
                                        tempDistanceError1 = (0.002 + 0.00004) * myController.FullScale / Math.Sqrt(3); // [um], (niepewność) dla próbki dyfuzyjnej odbijającej
                                        tempDistanceError2 = tempDistanceError1;
                                        break;

                                    case 1:
                                        tempDistanceError1 = (0.0003 + 0.00004) * myController.FullScale / Math.Sqrt(3); // [um], (niepewność) dla próbki przezroczystej
                                        tempDistanceError2 = tempDistanceError1;
                                        break;
                                }

                                tempThicknessError = myController.RefractiveIndex * tempDistanceError1 * Math.Sqrt(2);
                                
                                tempIntensity1 = double.Parse(results[3]) / 4095 * 100; // [%]
                                tempIntensity2 = double.Parse(results[4]) / 4095 * 100; // [%]

                                lock (myLock)
                                {
                                    myController.Distance1 = tempDistance1;
                                    myController.DistanceError1 = tempDistanceError1;
                                    myController.Distance2 = tempDistance2;
                                    myController.DistanceError2 = tempDistanceError2;
                                    myController.Intensity1 = tempIntensity1;
                                    myController.Intensity2 = tempIntensity2;
                                    myController.Thickness = tempThickness;
                                    myController.ThicknessError = tempThicknessError;
                                }
                            
                            break;

                        case 2:
                            
                            //

                                break;
                    }
                }
            }
            else // każda inna linijka niż echo rozkazu lub dane liczbowe będzie ignorowana
            {
                return;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Blok odświeżający pole odczytowe interfejsu w zależności od wybranego trybu pomiaru

            if (myStatus.basicSettingsList[0] == true)
            {
                switch (myController.MeasurementType)
                {
                    case 0:
                        intensityLabel2.Visible = false;
                        distanceLabel2.Visible = false;
                        distanceErrorLabel2.Visible = false;

                        intensityValue2.Visible = false;
                        distanceValue2.Visible = false;
                        distanceErrorValue2.Visible = false;

                        thicknessLabel.Visible = false;
                        thicknessValue.Visible = false;
                        thicknessErrorLabel.Visible = false;
                        thicknessErrorValue.Visible = false;

                        break;

                    case 1:
                        intensityLabel2.Visible = true;
                        distanceLabel2.Visible = true;
                        distanceErrorLabel2.Visible = true;

                        intensityValue2.Visible = true;
                        distanceValue2.Visible = true;
                        distanceErrorValue2.Visible = true;

                        thicknessLabel.Visible = true;
                        thicknessValue.Visible = true;
                        thicknessErrorLabel.Visible = true;
                        thicknessErrorValue.Visible = true;

                        break;

                    case 2:

                        //

                        break;

                }
            }

            // Blok odświeżający wyświetlane liczby i komunikat informacyjny

            if (isMeasurementRunning == true && myStatus.areBasicSettingsSet == true)
            {
                double tempIntensity1;
                double tempDistance1;
                double tempDistanceError1;

                switch (myController.MeasurementType)
                {
                    case 0:

                        lock (myLock)
                        {
                            tempIntensity1 = myController.Intensity1;
                            tempDistance1 = myController.Distance1;
                            tempDistanceError1 = myController.DistanceError1;
                        }

                        intensityValue.Text = tempIntensity1.ToString("0.000");
                        distanceValue.Text = tempDistance1.ToString("0.000");
                        distanceErrorValue.Text = tempDistanceError1.ToString("0.000");

                        if (measurementTypeComboBoxSelected == false && portComboBoxSelected == false && sampleComboBoxSelected == false && isDarkSpectrumGroupBoxEntered == false)
                        {
                            if (isMeasurementStopped == true)
                            {
                                SetHoldInformation();
                            }
                            else if (tempIntensity1 == 0 && tempDistance1 == 0)
                            {
                                SetWrongInformation();
                            }
                            else
                            {
                                SetCorrectInformation();
                            }
                        }
                        break;

                    case 1:

                        double tempIntensity2;
                        double tempDistance2;
                        double tempDistanceError2;
                        double tempThickness;
                        double tempThicknessError;

                        lock (myLock)
                        {
                            tempIntensity1 = myController.Intensity1;
                            tempDistance1 = myController.Distance1;
                            tempDistanceError1 = myController.DistanceError1;
                            tempIntensity2 = myController.Intensity2;
                            tempDistance2 = myController.Distance2;
                            tempDistanceError2 = myController.DistanceError2;
                            tempThickness = myController.Thickness;
                            tempThicknessError = myController.ThicknessError;
                        }

                        intensityValue.Text = tempIntensity1.ToString("0.000");
                        distanceValue.Text = tempDistance1.ToString("0.000");
                        distanceErrorValue.Text = tempDistanceError1.ToString("0.000");

                        intensityValue2.Text = tempIntensity2.ToString("0.000");
                        distanceValue2.Text = tempDistance2.ToString("0.000");
                        distanceErrorValue2.Text = tempDistanceError2.ToString("0.000");

                        thicknessValue.Text = tempThickness.ToString("0.000");
                        thicknessErrorValue.Text = tempThicknessError.ToString("0.000");

                        if (measurementTypeComboBoxSelected == false && portComboBoxSelected == false && sampleComboBoxSelected == false && isDarkSpectrumGroupBoxEntered == false)
                        {
                            if (isMeasurementStopped == true)
                            {
                                SetHoldInformation();
                            }
                            else if ((tempIntensity1 == 0 && tempDistance1 == 0) || (tempIntensity2 == 0 && tempDistance2 == 0))
                            {
                                SetWrongInformation();
                            }
                            else
                            {
                                SetCorrectInformation();
                            }
                        }

                        break;

                    case 2:

                        //

                        break;

                }
            }
            else if (isSecondaryFormClosed == true)
            {
                SetDefaultPicture();
                SetDefaultInformation();

                isSecondaryFormClosed = false;
            }
        }

        private void settingsTimer1_Tick(object sender, EventArgs e)
        {
            UpdateAllFields1();

            if (myStatus.areBasicSettingsSet == false)
            {
                myStatus.VerifyIfBasicSettingsAreSet();
            }

            if (myStatus.areExtraSettingsSet == false)
            {
                myStatus.VerifyIfExtraSettingsAreSet();
            }
        }

        // measurementTypeComboBox

        private void measurementTypeComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            measurementTypeComboBoxSelected = true;

            SetDefaultPicture();

            information.Text = "Tryby pomiarów:" + Environment.NewLine;
            information.AppendText("0 - konfokalny 1: pomiar odległości od pojedynczej powierzchni." + Environment.NewLine);
            information.AppendText("1 - konfokalny 2: pomiar odległości (grubości) między dwoma powierzchniami odbijającymi. Należy podać w Ustawieniach współczynnik załamania ośrodka." + Environment.NewLine);
            information.AppendText("2 - interferometryczny 2: (opcjonalny) pomiar odległości (grubości) między dwoma powierzchniami odbijającymi. Należy podać w Ustawieniach współczynnik załamania ośrodka.");

        }

        private void measurementTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (measurementTypeComboBox.SelectedIndex == -1) return;

            myController.MeasurementType = int.Parse(myController.MeasurementTypes[measurementTypeComboBox.SelectedIndex]);

            if (myStatus.basicSettingsList[1] == true)
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }

                serialPort1.WriteLine("$MOD" + myController.MeasurementType.ToString());

                switch (myController.MeasurementType)
                {
                    case 0:
                        serialPort1.WriteLine("$SOD1,0,0,1,0,0,0,0");
                        break;
                    case 1:
                        serialPort1.WriteLine("$SOD1,1,1,0,1,1,0,0");
                        break;
                    case 2:

                        break;
                }

            }

            measurementTypeComboBoxSelected = false;
            myStatus.basicSettingsList[0] = true;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
            
        }

        private void measurementTypeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            measurementTypeComboBoxSelected = false;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        private void saveToEEPROMButton1_Click(object sender, EventArgs e)
        {
            if (myStatus.basicSettingsList[1] == true)
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }
                serialPort1.WriteLine("$SSU");
            }
        }

        // portComboBox

        private void portComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            portComboBoxSelected = true;

            SetDefaultPicture();

            information.Text = "Wybierz właściwy port COM z listy.";
        }

        private void portComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (portComboBox.SelectedIndex == -1) return;

            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = portNames[portComboBox.SelectedIndex];
            }
            else
            {
                serialPort1.Close();
                serialPort1.PortName = portNames[portComboBox.SelectedIndex];
                serialPort1.Open();
            }

            // Odczytanie możliwych danych z kontrolera

            GetSettingsFromController();

            portComboBoxSelected = false;
            myStatus.basicSettingsList[1] = true;

            // Odblokowanie pozostałych części interfejsu

            if (initialControlsSet == false)
            {
                measurementTypeComboBox.Enabled = true;
                saveToEEPROMButton1.Enabled = true;
                sampleComboBox.Enabled = true;
                calibrateDarkButton.Enabled = true;
                settingsButton.Enabled = true;
                startButton.Enabled = true;
                multipleMeasurementButton.Enabled = true;
            }

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        private void portComboBox_DropDownClosed(object sender, EventArgs e)
        {
            portComboBoxSelected = false;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        // sampleComboBox

        private void sampleComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            sampleComboBoxSelected = true;

            SetDefaultPicture();

            information.Text = "Typy próbek:" + Environment.NewLine;
            information.AppendText("0 - dyfuzyjna próbka rozpraszająca (R > 5%)" + Environment.NewLine);
            information.AppendText("1 - próbka przezroczysta (R <= 5%)");
        }

        private void sampleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sampleComboBox.SelectedIndex == -1) return;

            myController.SampleType = int.Parse(myController.SampleNames[sampleComboBox.SelectedIndex]);

            sampleComboBoxSelected = false;
            myStatus.basicSettingsList[2] = true;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        private void sampleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            sampleComboBoxSelected = false;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        private void darkSpectrumGroupBox_Enter(object sender, EventArgs e)
        {
            isDarkSpectrumGroupBoxEntered = true;

            SetDefaultPicture();

            information.Text = "Tryby kalibracji spektrum czerni:" + Environment.NewLine;
            information.AppendText("1. szybka: wykonywana jednorazowo, usuwana z pamięci po wyłączeniu urządzenia" + Environment.NewLine);
            information.AppendText("2. standardowa: pełna kalibracja, zapisywana w pamięci EEPROM urządzenia." + Environment.NewLine);
            information.AppendText(Environment.NewLine + "Ważne! Należy zadbać, by w zasięgu pomiaru czujnika nie było żadnego obiektu i zasłonić jego końcówkę.");
        }

        private void darkSpectrumGroupBox_Leave(object sender, EventArgs e)
        {
            isDarkSpectrumGroupBoxEntered = false;

            if (isMeasurementStopped == true)
            {
                SetHoldInformation();
            }
            else
            {
                SetDefaultPicture();
                SetDefaultInformation();
            }
        }

        private void calibrateDarkButton_Click(object sender, EventArgs e)
        {
            if (myStatus.basicSettingsList[1] == true)
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }
                if (fastDarkRadioButton.Checked == true)
                {
                    serialPort1.WriteLine("$FDK");
                }
                else if (standardDarkRadioButton.Checked == true)
                {
                    serialPort1.WriteLine("$DRK");
                }
                else
                {
                    return;
                }
            }

        }

        // Dół interfejsu

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (myStatus.basicSettingsList[1] == true)
            {
                Form2 settingsForm = new Form2(serialPort1, myController, myStatus);
                settingsForm.Show();
            }
        }

        private void multipleMeasurementButton_Click(object sender, EventArgs e)
        {
            switch (myController.MeasurementType)
            {
                case 0:
                    if (myStatus.areBasicSettingsSet == true)
                    {
                        Form3 multipleMeasurementForm = new Form3(serialPort1, myController, myStatus);
                        multipleMeasurementForm.Show();

                        isMeasurementRunning = true;
                    }
                    break;

                case 1:
                    if (myStatus.areBasicSettingsSet == true && myStatus.extraSettingsList[0] == true)
                    {
                        Form3 multipleMeasurementForm = new Form3(serialPort1, myController, myStatus);
                        multipleMeasurementForm.Show();

                        isMeasurementRunning = true;
                    }
                    break;

                case 2:
                    break;
            }

            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (myStatus.areBasicSettingsSet == true)
            {
                if (isMeasurementRunning == false)
                {
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.Open();
                    }
                    isMeasurementRunning = true;
                    isMeasurementStopped = false;
                    startButton.Text = "STOP";
                }
                else
                {
                    isMeasurementRunning = false;
                    isMeasurementStopped = true;
                    startButton.Text = "START";

                    SetHoldInformation();
                }
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                isMeasurementRunning = false;
            }
        }

        

        

        

        
    }
}
