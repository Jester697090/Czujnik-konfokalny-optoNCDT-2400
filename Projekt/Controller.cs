using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Controller
    {
        // Pola z wynikami pomiarów wykonywanych przez kontroler

        private double distance1;
        private double distanceError1;
        private double distance2;
        private double distanceError2;
        private double intensity1;
        private double intensity2;
        private double thickness;
        private double thicknessError;

        // Pola zawierające ustawienia i dane kontrolera

        private int averaging;
        private int spectralAveraging;
        private int samplingRate;
        private double refractiveIndex;
        private int detectionTreshold;
        private double fullScale;
        private int leftDetectionLimit;
        private int rightDetectionLimit;

        private List<String> sampleNames = new List<String>();
        private List<String> measurementTypes = new List<String>();
        private List<Sensor> sensors = new List<Sensor>();

        private int[] samplingRates;

        private string serialNumber;
        private string controllerSoftware;
        private string dspSoftware;

        private int sensorID; //
        private Sensor chosenSensor;

        private int sampleType;
        private int measurementType;

        // Konstruktory

        public Controller()
        {
            samplingRates = new int[] { 3, 30, 4, 100, 5, 300, 6, 1000 };

            FillMeasurementTypes();
            FillSampleNames();
            FillSensors();
        }


        // Właścwiości 

        public double Distance1
        {
            get
            {
                return distance1;
            }
            set
            {
                distance1 = value;
            }
        }

        public double DistanceError1
        {
            get
            {
                return distanceError1;
            }
            set
            {
                distanceError1 = value;
            }
        }

        public double Distance2
        {
            get
            {
                return distance2;
            }
            set
            {
                distance2 = value;
            }
        }

        public double DistanceError2
        {
            get
            {
                return distanceError2;
            }
            set
            {
                distanceError2 = value;
            }
        }

        public double Intensity1
        {
            get
            {
                return intensity1;
            }
            set
            {
                intensity1 = value;
            }
        }

        public double Intensity2
        {
            get
            {
                return intensity2;
            }
            set
            {
                intensity2 = value;
            }
        }

        public double Thickness
        {
            get
            {
                return thickness;
            }
            set
            {
                thickness = value;
            }
        }

        public double ThicknessError
        {
            get
            {
                return thicknessError;
            }
            set
            {
                thicknessError = value;
            }
        }

        public int Averaging
        {
            get
            {
                return averaging;
            }
            set
            {
                if(value >= 1 && value <= 999)
                {
                    averaging = value;
                }
            }
        }

        public int SpectralAveraging
        {
            get
            {
                return spectralAveraging;
            }
            set
            {
                if (value >= 1 && value <= 99)
                {
                    spectralAveraging = value;
                }
            }
        }

        public int SamplingRate
        {
            get
            {
                return samplingRate;
            }
            set
            {
                if (value == 30 || value == 100 || value == 300 || value == 1000)
                {
                    samplingRate = value;
                }
            }
        }

        public double RefractiveIndex
        {
            get
            {
                return refractiveIndex;
            }
            set
            {
                if (value >= 1.000 && value <= 5.000)
                {
                    refractiveIndex = value;
                }
            }
        }

        public int DetectionTreshold
        {
            get
            {
                return detectionTreshold;
            }
            set
            {
                if (value >= 0 && value <= 4094)
                {
                    detectionTreshold = value;
                }
            }
        }

        public double FullScale
        {
            get
            {
                return fullScale;
            }
            set
            {
                if (value == 80 || value == 350 || value == 1000 || value == 3000 || value == 10000 || value == 24000)
                {
                    fullScale = value;
                }
            }
        }

        public IList<String> SampleNames
        {
            get
            {
                return sampleNames.AsReadOnly();
            }
        }

        public IList<String> MeasurementTypes
        {
            get
            {
                return measurementTypes.AsReadOnly();
            }
        }

        public IList<Sensor> Sensors
        {
            get
            {
                return sensors.AsReadOnly();
            }
        }

        public int[] SamplingRates
        {
            get
            {
                return samplingRates;
            }
        }

        public int LeftDetectionLimit
        {
            get
            {
                return leftDetectionLimit;
            }
            set
            {
                if (value >=0 && value <= 32767)
                {
                    leftDetectionLimit = value;
                }
            }
        }

        public int RightDetectionLimit
        {
            get
            {
                return rightDetectionLimit;
            }
            set
            {
                if (value >= 0 && value <= 32767)
                {
                    rightDetectionLimit = value;
                }
            }
        }

        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }

        public string ControllerSoftware
        {
            get
            {
                return controllerSoftware;
            }
            set
            {
                controllerSoftware = value;
            }
        }

        public string DspSoftware
        {
            get
            {
                return dspSoftware;
            }
            set
            {
                dspSoftware = value;
            }
        }

        public int SensorID
        {
            get
            {
                return sensorID;
            }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    sensorID = value;
                }
            }
        }

        public Sensor ChosenSensor
        {
            get
            {
                return chosenSensor;
            }
            set
            {
                chosenSensor = value;
            }
        }

        public int SampleType
        {
            get
            {
                return sampleType;
            }
            set
            {
                if (value >= 0 && value <= 1)
                {
                    sampleType = value;
                }
            }
        }

        public int MeasurementType
        {
            get
            {
                return measurementType;
            }
            set
            {
                if (value >= 0 && value <= 2)
                {
                    measurementType = value;
                }
            }
        }

        // Metody inicjacyjne

        public void FillSampleNames()
        {
            sampleNames.Add("0");
            sampleNames.Add("1");
        }

        public void FillMeasurementTypes()
        {
            measurementTypes.Add("0");
            measurementTypes.Add("1");
            measurementTypes.Add("2");
        }

        public void FillSensors()
        {
            Sensor s0 = new Sensor("IFD 2400-008", 80, 2100, 2140, 2180, 7, 24);
            Sensor s1 = new Sensor("IFD 2400-035", 350, 12700, 12875, 13050, 10, 27);
            Sensor s2 = new Sensor("IFD 2400-1", 1000, 24000, 24500, 25000, 10, 24);
            Sensor s3 = new Sensor("IFD 2400-3", 3000, 27000, 28500, 30000, 25, 12);
            Sensor s4 = new Sensor("IFD 2400-10", 10000, 67000, 72000, 77000, 50, 12);
            Sensor s5 = new Sensor("IFD 2400-24", 24000, 222000, 234000, 246000, 100, 5);

            sensors.Add(s0);
            sensors.Add(s1);
            sensors.Add(s2);
            sensors.Add(s3);
            sensors.Add(s4);
            sensors.Add(s5);
        }

        public class Status
        {
            public List<Boolean> basicSettingsList = new List<Boolean>();
            
            public bool isMeasurementTypeChosen;
            public bool isCOMPortChosen;
            public bool isSampleTypeChosen;
            public bool isSensorChosen;
            public bool isAveragingSet;
            public bool isSpectralAveragingSet;
            public bool isSamplingRateSet;
            public bool isDetectionTresholdSet;

            public List<Boolean> extraSettingsList = new List<Boolean>();

            public bool isRefractiveIndexSet;
            public bool isLeftDetectionLimitSet;
            public bool isRightDetectionLimitSet;

            public bool bracketedModeChosen;

            public bool areBasicSettingsSet;
            public bool areExtraSettingsSet;


            public Status()
            {
                isMeasurementTypeChosen = false;
                isCOMPortChosen = false;
                isSampleTypeChosen = false;
                isSensorChosen = false;
                isAveragingSet = false;
                isSpectralAveragingSet = false;
                isSamplingRateSet = false;
                isDetectionTresholdSet = false;

                basicSettingsList.Add(isMeasurementTypeChosen); // 0
                basicSettingsList.Add(isCOMPortChosen); // 1
                basicSettingsList.Add(isSampleTypeChosen); // 2
                basicSettingsList.Add(isSensorChosen); // 3
                basicSettingsList.Add(isAveragingSet); // 4
                basicSettingsList.Add(isSpectralAveragingSet); // 5
                basicSettingsList.Add(isSamplingRateSet); // 6
                basicSettingsList.Add(isDetectionTresholdSet); // 7

                isRefractiveIndexSet = false;
                isLeftDetectionLimitSet = false;
                isRightDetectionLimitSet = false;

                extraSettingsList.Add(isRefractiveIndexSet); // 0
                extraSettingsList.Add(isLeftDetectionLimitSet); // 1
                extraSettingsList.Add(isRightDetectionLimitSet); // 2

                bracketedModeChosen = false;

                areBasicSettingsSet = false;
                areExtraSettingsSet = false;
        }

            public void VerifyIfBasicSettingsAreSet()
            {
                int n = 0;

                foreach (bool b in basicSettingsList)
                {
                    if (b == true)
                    {
                        n++;
                    }
                }

                if (n == basicSettingsList.Count)
                {
                    areBasicSettingsSet = true;
                }
            }

            public void VerifyIfExtraSettingsAreSet()
            {
                int n = 0;

                foreach (bool b in extraSettingsList)
                {
                    if (b == true)
                    {
                        n++;
                    }
                }

                if (n == extraSettingsList.Count)
                {
                    areExtraSettingsSet = true;
                }
            }
        }



    }
}
