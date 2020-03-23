using System;

namespace DEV_3
{
    public class Chassis
    {
        private double _numberOfWheels;
        private string _serialNumber;
        private double _permissibleLoad;

        public double NumberOfWheels
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _numberOfWheels = value;
            }

            get
            {
                return _numberOfWheels;
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

        public double PermissibleLoad
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _permissibleLoad = value;
            }

            get
            {
                return _permissibleLoad;
            }
        }

        public Chassis(double numberOfWheels, string serialNumber, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            SerialNumber = serialNumber;
            PermissibleLoad = permissibleLoad;
        }

        public string GetInfo()
        {
            return ("Chassis info: Number of wheels: " + NumberOfWheels + " Serial number: " + SerialNumber
                    + " Permissible load: " + PermissibleLoad);
        }
    }
}
