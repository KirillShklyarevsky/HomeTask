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
            string engineInfo = "Engine info: Power: " + Power + " Capacity: " + Capacity
                                + " Type: " + EngineType + " Serial number: " + SerialNumber;
            return engineInfo;
        }
    }
}
