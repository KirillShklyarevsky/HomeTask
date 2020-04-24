using System;

namespace Calculator
{
    class LengthConverter
    {
        private const double FeetsInMeter = 0.3048;

        public double FeetsToMeters(double feets)
        {
           return feets * FeetsInMeter;
        }

        public double MetersToFeets(double feets)
        {
            return feets * FeetsInMeter;
        }
        
        public double Convert(double length, string direction)
        {
            if (direction == "FM")
            {
                return FeetsToMeters(length);
            }
            else
            {
                return MetersToFeets(length);
            }
        }
    }
}