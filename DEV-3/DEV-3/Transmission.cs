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
            get
            {
                return _transmissionType;
            }
            set
            {
                _transmissionType = value;
            }
        }

        public int NumberOfGears
        {
            get
            {
                return _numberOfGears;
            }
            set
            {
                _numberOfGears = value;
            }
        }

        public string Manufacturer
        {
            set
            {
                _manufacturer = value;
            }

            get
            {
                return _manufacturer;
            }
        }

        public string GetInfo()
        {
            string TransmissionInfo = "Transmisssion info: Transmission type: " + TransmissionType + " Number of gears: " + NumberOfGears
                               + " Manufacturer: " + Manufacturer;
            return TransmissionInfo;
        }
    }
}
