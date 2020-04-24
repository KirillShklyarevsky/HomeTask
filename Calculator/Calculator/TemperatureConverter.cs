using System;

namespace Calculator
{
    class TemperatureConverter
    {
        private const double TemperatureConst = 32;
        private const double ConversionCoefficient = 9.0 / 5;
        private const double ReverceConversionCoefficient = 5.0 / 9;

        public double CelsiusToFahrenheit(double celsius)
        {
            return (ConversionCoefficient * celsius + TemperatureConst);
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (ReverceConversionCoefficient * (fahrenheit - TemperatureConst));
        }

        public double Convert(double temperature, string direction)
        {
            if (direction == "CF")
            {
                return CelsiusToFahrenheit(temperature);
            }
            else
            {
                return FahrenheitToCelsius(temperature);
            }
        }
    }
}