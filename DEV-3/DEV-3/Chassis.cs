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
