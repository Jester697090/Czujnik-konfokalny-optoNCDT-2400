using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class MultipleMeasurement
    {
        private double stage;
        private double stageDelta;
        private List<double> stageValues;

        private List<double> distance1Values;
        private List<double> intensity1Values;

        private List<double> distance2Values;
        private List<double> intensity2Values;
        private List<double> thicknessValues;

        private double stageDifference;
        private double distanceDifference;
        private double thicknessDifference;
        private double amplitude;


        public MultipleMeasurement()
        {
            stage = 0;
            stageDelta = 10;
            stageValues = new List<double>();

            distance1Values = new List<double>();
            intensity1Values = new List<double>();

            distance2Values = new List<double>();
            intensity2Values = new List<double>();
            thicknessValues = new List<double>();
        }


        public double Stage
        {
            get
            {
                return stage;
            }
            set
            {
                stage = value;
            }
        }

        public double StageDelta
        {
            get
            {
                return stageDelta;
            }
            set
            {
                if (value >= 10 && value <= 5000)
                {
                    stageDelta = value;
                }
            }
        }

        public List<double> StageValues
        {
            get
            {
                return stageValues;
            }
            set
            {
                stageValues = value;
            }
        }

        public List<double> Distance1Values
        {
            get
            {
                return distance1Values;
            }
            set
            {
                distance1Values = value;
            }
        }

        public List<double> Intensity1Values
        {
            get
            {
                return intensity1Values;
            }
            set
            {
                intensity1Values = value;
            }
        }

        public List<double> Distance2Values
        {
            get
            {
                return distance2Values;
            }
            set
            {
                distance2Values = value;
            }
        }

        public List<double> Intensity2Values
        {
            get
            {
                return intensity2Values;
            }
            set
            {
                intensity2Values = value;
            }
        }

        public List<double> ThicknessValues
        {
            get
            {
                return thicknessValues;
            }
            set
            {
                thicknessValues = value;
            }
        }

        public double StageDifference
        {
            get
            {
                return stageDifference;
            }
            set
            {
                    stageDifference = value;
            }
        }

        public double DistanceDifference
        {
            get
            {
                return distanceDifference;
            }
            set
            {
                distanceDifference = value;
            }
        }

        public double ThicknessDifference
        {
            get
            {
                return thicknessDifference;
            }
            set
            {
                thicknessDifference = value;
            }
        }

        public double Amplitude
        {
            get
            {
                return amplitude;
            }
            set
            {
                amplitude = value;
            }
        }

    }
}
