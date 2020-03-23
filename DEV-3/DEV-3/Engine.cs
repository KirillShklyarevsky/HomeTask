using System;

namespace DEV_3
{
    public class Engine
    {
        private double _power;
        private double _capacity;
        private string _engineType;
        private string _serialNumber;

        public double Power
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _power = value;
            }

            get
            {
                return _power;
            }
        }

        public double Capacity
        {
            set
            {
                if (value <0)
                {
                    throw new ArgumentException();
                }

                _capacity = value;
            }

            get
            {
                return _capacity;
            }
        }

        public string EngineType
        {
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _engineType = value;
            }

            get
            {
                return _engineType;
            }
        }

        public string SerialNumber
        {
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _serialNumber = value;
            }

            get
            {
                return _serialNumber;
            }
        }

        public Engine(double power, double capacity, string engineType, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            EngineType = engineType;
            SerialNumber = serialNumber;
        }

        public string GetInfo()
        {
            return ("Engine info: Power: " + Power + " Capacity: " + Capacity
                    + " Type: " + EngineType + " Serial number: " + SerialNumber);
        }
    }
}
