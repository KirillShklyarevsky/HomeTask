using System;

namespace DEV_3
{
    public class Car : VehicleBase
    {
        private int _numberOfDoors;

        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
        public int NumberOfDoors
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                _numberOfDoors = value;
            }

            get
            {
                return _numberOfDoors;
            }
        }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfDoors"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public Car(int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"Number of doors: {NumberOfDoors}");
        }
    }
}
