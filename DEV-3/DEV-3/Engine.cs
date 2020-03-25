using System;

namespace DEV_3
{
    public class Engine
    {
        private double _power;
        private double _capacity;
        private string _engineType;
        private string _serialNumber;

        /// <summary>
        /// Method that set and get value of power field
        /// </summary>
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

        /// <summary>
        /// Method that set and get value of capacity field
        /// </summary>
        public double Capacity
        {
            set
            {
                if (value < 0)
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

        /// <summary>
        /// Method that set and get value of engine type field
        /// </summary>
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

        /// <summary>
        /// Method that set and get value of serial number field
        /// </summary>
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

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="power"></param>
        /// <param name="capacity"></param>
        /// <param name="engineType"></param>
        /// <param name="serialNumber"></param>
        public Engine(double power, double capacity, string engineType, string serialNumber)
        {
            Power = power;
            Capacity = capacity;
            EngineType = engineType;
            SerialNumber = serialNumber;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Engine info: Power: " + Power + " Capacity: " + Capacity
                    + " Type: " + EngineType + " Serial number: " + SerialNumber);
        }
    }
}
