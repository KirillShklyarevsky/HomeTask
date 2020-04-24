using System;

namespace Calculator
{
    class Converter
    {
        public double Convert(double value, string direction)
        {
            if (direction == "CF" || direction == "FC")
            {
                TemperatureConverter temperatureConverter = new TemperatureConverter();
                return temperatureConverter.Convert(value, direction);
            }
            if (direction == "FM" || direction == "MF")
            {
                LengthConverter lengthConverter = new LengthConverter();
                return lengthConverter.Convert(value, direction);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}