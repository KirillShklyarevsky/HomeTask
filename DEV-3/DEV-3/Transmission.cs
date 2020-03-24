using System;

namespace DEV_3
{
    public class Transmission
    {
        private string _transmissionType;
        private int _numberOfGears;
        private string _manufacturer;

        public string TransmissionType
        {
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _transmissionType = value;
            }

            get
            {
                return _transmissionType;
            }
        }

        public int NumberOfGears
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                _numberOfGears = value;
            }

            get
            {
                return _numberOfGears;
            }
        }

        public string Manufacturer
        {
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentException();
                }
                _manufacturer = value;
            }

            get
            {
                return _manufacturer;
            }
        }

        public Transmission(string transmissionType, int numberOfGears, string manufacture)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacture;
        }

        public string GetInfo()
        {
            return ("Transmisssion info: Transmission type: " + TransmissionType + " Number of gears: " + NumberOfGears 
                    + " Manufacturer: " + Manufacturer);
        }
    }
}
