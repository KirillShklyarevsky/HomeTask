using System;

namespace DEV_3
{
    public class Scooter : VehicleBase
    {
        private double _maximumSpeed;

        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
        public double MaximumSpeed
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maximumSpeed = value;
            }

            get
            {
                return _maximumSpeed;
            }
        }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumSpeed"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public Scooter(int maximumSpeed, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumSpeed = maximumSpeed;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string scooterInfo = base.GetInfo();
            return (scooterInfo + $"Maximum speed: {MaximumSpeed}");
        }
    }
}
