using System;

namespace DEV_3
{
    public class Transmission
    {
        private string _transmissionType;
        private int _numberOfGears;
        private string _manufacturer;

        /// <summary>
        /// Method that set and get value of transmission type field
        /// </summary>
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

        /// <summary>
        /// Method that set and get value of gears number field
        /// </summary>
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

        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
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

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="transmissionType"></param>
        /// <param name="numberOfGears"></param>
        /// <param name="manufacture"></param>
        public Transmission(string transmissionType, int numberOfGears, string manufacture)
        {
            TransmissionType = transmissionType;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacture;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return ("Transmisssion info: Transmission type: " + TransmissionType + " Number of gears: " + NumberOfGears 
                    + " Manufacturer: " + Manufacturer);
        }
    }
}
