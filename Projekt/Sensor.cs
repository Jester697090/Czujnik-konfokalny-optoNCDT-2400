using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Sensor
    {
        private string name;
        private double measuringRange;
        private double referenceDistance;
        private double midRange;
        private double endOfMeasuringRange;
        private double spotDiameter;
        private double linearity;
        private double resolution;
        private double maxTiltDirectReflection;

        public Sensor(string name, double measuringRange, double referenceDistance, double midRange, double endOfMeasuringRange)
        {
            this.name = name;
            this.measuringRange = measuringRange;
            this.referenceDistance = referenceDistance;
            this.midRange = midRange;
            this.endOfMeasuringRange = endOfMeasuringRange;

            linearity = 0.002 * measuringRange;
            resolution = 0.0003 * measuringRange;

        }

        public Sensor(string name, double measuringRange, double referenceDistance, double midRange, double endOfMeasuringRange, double spotDiameter, double maxTiltDirectReflection)
        {
            this.name = name;
            this.measuringRange = measuringRange;
            this.referenceDistance = referenceDistance;
            this.midRange = midRange;
            this.endOfMeasuringRange = endOfMeasuringRange;
            this.spotDiameter = spotDiameter;

            linearity = 0.002 * measuringRange;
            resolution = 0.0003 * measuringRange;

            this.maxTiltDirectReflection = maxTiltDirectReflection;
        }

        public string GetName()
        {
            return name;
        }

        public double GetMeasuringRange()
        {
            return measuringRange;
        }

        public double GetReferenceDistance()
        {
            return referenceDistance;
        }

        public double GetMidRange()
        {
            return midRange;
        }

        public double GetEndOfMeasuringRange()
        {
            return endOfMeasuringRange;
        }

        public double GetSpotDiameter()
        {
            return spotDiameter;
        }

        public double GetLinearity()
        {
            return linearity;
        }

        public double GetResolution()
        {
            return resolution;
        }

        public double GetMaxTiltDirectReflection()
        {
            return maxTiltDirectReflection;
        }

        public double Error()
        {
            return linearity + resolution;
        }
    }
}
