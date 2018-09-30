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
    public partial class Form3 : Form
    {
        Object myLock = new Object();
        SerialPort serialPort1;
        Controller myController;
        Controller.Status myStatus;
        MultipleMeasurement myMeasurement = new MultipleMeasurement();

        int n = -1;

        double min;
        double max;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(SerialPort sp, Controller c, Controller.Status s)
        {
            serialPort1 = sp;
            myController = c;
            myStatus = s;

            InitializeComponent();
        }

        private void SetLabels()
        {
            switch (myController.MeasurementType)
            {
                case 0:
                    distanceLabel.Text = "Odległość [um]";
                    extremeDistanceLabel.Text = "Odległość [um]";
                    break;
                case 1:
                    distanceLabel.Text = "Grubość [um]";
                    extremeDistanceLabel.Text = "Grubość [um]";
                    break;
                case 2:
                    break;
            }
        }

        private void SetCorrectInformation()
        {
            icon.Image = MyContent.correct;
            icon.Refresh();

            information.Text = "Czujnik mierzy prawidłowo. Można wykonać kolejny pomiar." + Environment.NewLine;
            information.AppendText(Environment.NewLine + "Obecny tryb pomiarowy: " + myController.MeasurementType.ToString() + Environment.NewLine);
            information.AppendText("Wykonanych pomiarów: " + (n + 1).ToString());
        }

        private void SetWrongInformation()
        {
            icon.Image = MyContent.wrong;
            icon.Refresh();

            information.Text = "Czujnik nie mierzy prawidłowo. Należy sprawdzić, czy obiekt nie wyszedł z zakresu pomiarowego czujnika." + Environment.NewLine;
            information.AppendText(Environment.NewLine + "Obecny tryb pomiarowy: " + myController.MeasurementType.ToString() + Environment.NewLine);
            information.AppendText("Wykonanych pomiarów: " + (n + 1).ToString());
        }

        private void UpdateFields()
        {
            if (n < 0)
            {
                return;
            }

            switch (myController.MeasurementType)
            {
                case 0:
                    if (n == 0)
                    {
                        lastButOneStageValue.Text = "";
                        lastButOneDistanceValue.Text = "";

                        lastStageValue.Text = myMeasurement.StageValues[n].ToString("0.000");
                        lastDistanceValue.Text = myMeasurement.Distance1Values[n].ToString("0.000");

                        stageDifferenceValue.Text = "";
                        distanceDifferenceValue.Text = "";

                        minDistanceValue.Text = myMeasurement.Distance1Values[n].ToString("0.000");
                        maxDistanceValue.Text = myMeasurement.Distance1Values[n].ToString("0.000");

                        amplitudeValue.Text = "0.000";
                    }
                    else if (n >= 1)
                    {
                        lastButOneStageValue.Text = myMeasurement.StageValues[n - 1].ToString("0.000");
                        lastButOneDistanceValue.Text = myMeasurement.Distance1Values[n - 1].ToString("0.000");

                        lastStageValue.Text = myMeasurement.StageValues[n].ToString("0.000");
                        lastDistanceValue.Text = myMeasurement.Distance1Values[n].ToString("0.000");

                        stageDifferenceValue.Text = myMeasurement.StageDifference.ToString("0.000");
                        distanceDifferenceValue.Text = myMeasurement.DistanceDifference.ToString("0.000");

                        minDistanceValue.Text = min.ToString("0.000");
                        maxDistanceValue.Text = max.ToString("0.000");

                        amplitudeValue.Text = myMeasurement.Amplitude.ToString("0.000");
                    }
                    break;
                case 1:
                    if (n == 0)
                    {
                        lastButOneStageValue.Text = "";
                        lastButOneDistanceValue.Text = "";

                        lastStageValue.Text = myMeasurement.StageValues[n].ToString("0.000");
                        lastDistanceValue.Text = myMeasurement.ThicknessValues[n].ToString("0.000");

                        stageDifferenceValue.Text = "";
                        distanceDifferenceValue.Text = "";

                        minDistanceValue.Text = myMeasurement.ThicknessValues[n].ToString("0.000");
                        maxDistanceValue.Text = myMeasurement.ThicknessValues[n].ToString("0.000");

                        amplitudeValue.Text = "0.000";
                    }
                    else if (n >= 1)
                    {
                        lastButOneStageValue.Text = myMeasurement.StageValues[n - 1].ToString("0.000");
                        lastButOneDistanceValue.Text = myMeasurement.ThicknessValues[n - 1].ToString("0.000");

                        lastStageValue.Text = myMeasurement.StageValues[n].ToString("0.000");
                        lastDistanceValue.Text = myMeasurement.ThicknessValues[n].ToString("0.000");

                        stageDifferenceValue.Text = myMeasurement.StageDifference.ToString("0.000");
                        distanceDifferenceValue.Text = myMeasurement.ThicknessDifference.ToString("0.000");

                        minDistanceValue.Text = min.ToString("0.000");
                        maxDistanceValue.Text = max.ToString("0.000");

                        amplitudeValue.Text = myMeasurement.Amplitude.ToString("0.000");
                    }
                    break;
                case 2:
                    break;
            }
        }

        private void ClearFields()
        {
            lastButOneStageValue.Text = "";
            lastStageValue.Text = "";
            stageDifferenceValue.Text = "";

            lastButOneDistanceValue.Text = "";
            lastDistanceValue.Text = "";
            distanceDifferenceValue.Text = "";

            minDistanceValue.Text = "";
            maxDistanceValue.Text = "";
            amplitudeValue.Text = "";
        }

        private void UpdateChart()
        {
            if (n < 0)
            {
                measurementChart.Hide();
                return;
            }

            if (measurementChart.Visible == false)
            {
                measurementChart.Show();
            }

            switch (myController.MeasurementType)
            {
                case 0:
                    measurementChart.Series["Distance"].Points.Clear();
                    measurementChart.Series["ErrorBars"].Points.Clear();

                    for (int m = 0; m <= n; m++)
                    {
                        measurementChart.Series["Distance"].Points.AddXY(myMeasurement.StageValues[m], myMeasurement.Distance1Values[m]);
                        measurementChart.Series["ErrorBars"].Points.AddXY(myMeasurement.StageValues[m], myMeasurement.Distance1Values[m], myMeasurement.Distance1Values[m] - myController.DistanceError1, myMeasurement.Distance1Values[m] + myController.DistanceError1); // myController.DistanceError1
                    }

                    break;
                case 1:
                    measurementChart.Series["Thickness"].Points.Clear();
                    measurementChart.Series["ErrorBars"].Points.Clear();

                    for (int m = 0; m <= n; m++)
                    {
                        measurementChart.Series["Thickness"].Points.AddXY(myMeasurement.StageValues[m], myMeasurement.ThicknessValues[m]);
                        measurementChart.Series["ErrorBars"].Points.AddXY(myMeasurement.StageValues[m], myMeasurement.ThicknessValues[m], myMeasurement.ThicknessValues[m] - myController.ThicknessError, myMeasurement.ThicknessValues[m] + myController.ThicknessError); // myController.ThicknessError
                    }
                    
                    break;
                case 2:
                    break;
            }

            if (min < 5)
            {
                measurementChart.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            }
            else
            {
                measurementChart.ChartAreas["ChartArea1"].AxisY.Minimum = min - 5;
            }
            
            measurementChart.ChartAreas["ChartArea1"].AxisY.Maximum = max + 5;

            measurementChart.Update();

        }
            
        



        private void Form3_Load(object sender, EventArgs e)
        {
            SetLabels();

            switch (myController.MeasurementType)
            {
                case 0:
                    measurementChart.Titles.Add("Odległość w funkcji położenia stolika");
                    measurementChart.Series["Series1"].Name = "Distance";
                    measurementChart.ChartAreas["ChartArea1"].AxisY.Title = "Odległość d [um]";
                    break;
                case 1:
                    measurementChart.Titles.Add("Grubość w funkcji położenia stolika");
                    measurementChart.Series["Series1"].Name = "Thickness";
                    measurementChart.ChartAreas["ChartArea1"].AxisY.Title = "Grubość h [um]";
                    break;
                case 2:
                    break;
            }

            measurementChart.Hide();

            if (myStatus.areBasicSettingsSet == true)
            {
                if (serialPort1.IsOpen == false)
                {
                        serialPort1.Open();
                }
            }

            updateTimer.Enabled = true;

        }

        private void measurementChart_Click(object sender, EventArgs e)
        {
            measurementChart.Update();
        }

        private void stageDeltaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            myMeasurement.StageDelta = double.Parse(stageDeltaNumericUpDown.Value.ToString());
        }

        private void newMeasurementButton_Click(object sender, EventArgs e)
        {
            n++; // n jest indeksem ostatniego elementu List, a (n + 1) liczbą wykonanych pomiarów

            myMeasurement.StageValues.Add(myMeasurement.Stage);
            myMeasurement.Stage = myMeasurement.Stage + myMeasurement.StageDelta;

            switch (myController.MeasurementType)
            {
                case 0:
                    lock (myLock)
                    {
                        myMeasurement.Distance1Values.Add(myController.Distance1);
                        myMeasurement.Intensity1Values.Add(myController.Intensity1);
                    }

                    if (n >= 1) // nie wykona się dla pierwszego pomiaru (n = 0)
                    {
                        myMeasurement.StageDifference = myMeasurement.StageValues[n] - myMeasurement.StageValues[n - 1];
                        myMeasurement.DistanceDifference = myMeasurement.Distance1Values[n] - myMeasurement.Distance1Values[n - 1];

                        min = myMeasurement.Distance1Values.Min();
                        max = myMeasurement.Distance1Values.Max();

                        myMeasurement.Amplitude = max - min;
                    }
                    break;
                case 1:
                    lock (myLock)
                    {
                        myMeasurement.Distance1Values.Add(myController.Distance1);
                        myMeasurement.Intensity1Values.Add(myController.Intensity1);
                        myMeasurement.Distance2Values.Add(myController.Distance2);
                        myMeasurement.Intensity2Values.Add(myController.Intensity2);
                        myMeasurement.ThicknessValues.Add(myController.Thickness);
                    }

                    if (n >= 1)
                    {
                        myMeasurement.StageDifference = myMeasurement.StageValues[n] - myMeasurement.StageValues[n - 1];
                        myMeasurement.ThicknessDifference = myMeasurement.ThicknessValues[n] - myMeasurement.ThicknessValues[n - 1];

                        min = myMeasurement.ThicknessValues.Min();
                        max = myMeasurement.ThicknessValues.Max();

                        myMeasurement.Amplitude = max - min;
                    }
                    break;
                case 2:
                    break;
            }

            UpdateFields();
            UpdateChart();

            if (n >= 0)
            {
                deleteOneButton.Enabled = true;
                resetButton.Enabled = true;
            }

        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            double tempDistance1;
            double tempIntensity1;

            switch (myController.MeasurementType)
            {
                case 0:
                    lock (myLock)
                    {
                        tempDistance1 = myController.Distance1;
                        tempIntensity1 = myController.Intensity1;
                    }

                    if (tempIntensity1 == 0 && tempDistance1 == 0)
                    {
                        SetWrongInformation();
                    }
                    else
                    {
                        SetCorrectInformation();
                    }

                    break;

                case 1:
                    double tempDistance2;
                    double tempIntensity2;

                    lock (myLock)
                    {
                        tempIntensity1 = myController.Intensity1;
                        tempDistance1 = myController.Distance1;
                        tempIntensity2 = myController.Intensity2;
                        tempDistance2 = myController.Distance2;
                    }

                    if ((tempIntensity1 == 0 && tempDistance1 == 0) || (tempIntensity2 == 0 && tempDistance2 == 0))
                    {
                        SetWrongInformation();
                    }
                    else
                    {
                        SetCorrectInformation();
                    }

                    break;

                case 2:
                    break;
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }

            Form1.isMeasurementRunning = false;
            Form1.isSecondaryFormClosed = true;
        }

        private void deleteOneButton_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                myMeasurement.StageValues.RemoveAt(n);

                if (n >= 1)
                {
                    myMeasurement.Stage = myMeasurement.StageValues[n - 1] + myMeasurement.StageDelta;
                }
                else
                {
                    myMeasurement.Stage = 0;
                }

                switch (myController.MeasurementType)
                {
                    case 0:
                        myMeasurement.Distance1Values.RemoveAt(n);
                        myMeasurement.Intensity1Values.RemoveAt(n);

                        break;
                    case 1:
                        myMeasurement.Distance1Values.RemoveAt(n);
                        myMeasurement.Intensity1Values.RemoveAt(n);
                        myMeasurement.Distance2Values.RemoveAt(n);
                        myMeasurement.Intensity2Values.RemoveAt(n);
                        myMeasurement.ThicknessValues.RemoveAt(n);

                        break;
                    case 2:
                        break;
                }
            }

            n--;

            if (n <= -1)
            {
                n = -1;

                ClearFields();
                UpdateChart();

                deleteOneButton.Enabled = false;
                resetButton.Enabled = false;

                return;
            }

            if (n >= 1)
            {
                myMeasurement.StageDifference = myMeasurement.StageValues[n] - myMeasurement.StageValues[n - 1];

                switch (myController.MeasurementType)
                {
                    case 0:
                        myMeasurement.DistanceDifference = myMeasurement.Distance1Values[n] - myMeasurement.Distance1Values[n - 1];

                        min = myMeasurement.Distance1Values.Min();
                        max = myMeasurement.Distance1Values.Max();

                        myMeasurement.Amplitude = max - min;

                        break;
                    case 1:
                        myMeasurement.ThicknessDifference = myMeasurement.ThicknessValues[n] - myMeasurement.ThicknessValues[n - 1];

                        min = myMeasurement.ThicknessValues.Min();
                        max = myMeasurement.ThicknessValues.Max();

                        myMeasurement.Amplitude = max - min;

                        break;
                    case 2:
                        break;
                }
            }

            UpdateFields();
            UpdateChart();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            myMeasurement.Stage = 0;
            stageDeltaNumericUpDown.Value = 10;
            myMeasurement.StageValues.Clear();

            myMeasurement.Distance1Values.Clear();
            myMeasurement.Intensity1Values.Clear();

            switch (myController.MeasurementType)
            {
                case 0:
                    myMeasurement.DistanceDifference = 0;

                    break;
                case 1:
                    myMeasurement.Distance2Values.Clear();
                    myMeasurement.Intensity2Values.Clear();
                    myMeasurement.ThicknessValues.Clear();

                    myMeasurement.ThicknessDifference = 0;

                    break;
                case 2:
                    break;
            }

            min = 0;
            max = 0;

            myMeasurement.StageDifference = 0;
            myMeasurement.Amplitude = 0;

            n = -1;

            ClearFields();
            UpdateChart();

            deleteOneButton.Enabled = false;
            resetButton.Enabled = false;

        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik Txt |*.txt";
            saveFileDialog.Title = "Zapisz dane jako...";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1: // .txt
                        if (n >= 0)
                        {
                            string[] dataLines = new string[n + 2];
                            string line;

                            switch (myController.MeasurementType)
                            {
                                case 0:
                                    line = "StageValue[um];Intensity1[%];Distance1[um]";
                                    dataLines[0] = line;

                                    for (int m = 0; m <= n; m++)
                                    {
                                        line = myMeasurement.StageValues[m].ToString("0.000") + ";" + myMeasurement.Intensity1Values[m].ToString("0.000") + ";" + myMeasurement.Distance1Values[m].ToString("0.000");
                                        dataLines[m + 1] = line;
                                    }

                                    fileStream.Close();
                                    System.IO.File.WriteAllLines(fileStream.Name, dataLines);

                                    break;
                                case 1:
                                    line = "StageValue[um];Intensity1[%];Distance1[um];Intensity2[%];Distance2[um];Thickness[um]";
                                    dataLines[0] = line;

                                    for (int m = 0; m <= n; m++)
                                    {
                                        line = myMeasurement.StageValues[m].ToString("0.000") + ";" + myMeasurement.Intensity1Values[m].ToString("0.000") + ";" + myMeasurement.Distance1Values[m].ToString("0.000") + ";" + myMeasurement.Intensity2Values[m].ToString("0.000") + ";" + myMeasurement.Distance2Values[m].ToString("0.000") + ";" + myMeasurement.ThicknessValues[m].ToString("0.000");
                                        dataLines[m + 1] = line;
                                    }

                                    fileStream.Close();
                                    System.IO.File.WriteAllLines(fileStream.Name, dataLines);

                                    break;
                                case 2:
                                    break;
                            }

                            
                        }
                        
                        break;

                    case 2: // .xls do dopisania
                        
                        break;
                }

                fileStream.Close();
            }
        }

        private void saveChartButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik JPeg|*.jpg|Bitmapa|*.bmp|Plik Png|*.png";
            saveFileDialog.Title = "Zapisz wykres jako...";
            saveFileDialog.ShowDialog();
 
            if (saveFileDialog.FileName != "")
            { 
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        measurementChart.SaveImage(fileStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                        break;

                    case 2:
                        measurementChart.SaveImage(fileStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                        break;

                    case 3:
                        measurementChart.SaveImage(fileStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        break;
                }

                fileStream.Close();
            }
        }
    }
}
