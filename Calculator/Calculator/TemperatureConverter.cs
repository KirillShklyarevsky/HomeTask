using System;

namespace Calculator
{
    class TemperatureConverter
    {
        private const double TemperatureConst = 32;

        public double CelsiusToFahrenheit(double celsius)
        {
            return ((9 * celsius) / 5) + TemperatureConst;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (5 * (fahrenheit - TemperatureConst)) / 9;
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