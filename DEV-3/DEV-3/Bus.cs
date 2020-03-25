using System;

namespace DEV_3
{
    public class Bus : VehicleBase
    {
        private int _seatsNumber;

        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
        public int SeatsNumber
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                _seatsNumber = value;
            }

            get
            {
                return _seatsNumber;
            }
        }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="seatsNumber"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public Bus(int seatsNumber, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            SeatsNumber = seatsNumber;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string busInfo = base.GetInfo();
            return (busInfo + $"Number of seats: {SeatsNumber}");
        }
    }
}