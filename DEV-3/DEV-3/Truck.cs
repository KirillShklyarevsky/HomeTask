using System;

namespace DEV_3
{
    public class Truck : VehicleBase
    {
        private double _maximumLoad;


        /// <summary>
        /// Method that set and get value of manufacturer field
        /// </summary>
        public double MaximumLoad
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _maximumLoad = value;
            }

            get
            {
                return _maximumLoad;
            }           
        }


        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="maximumLoad"></param>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public Truck(double maximumLoad, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumLoad = maximumLoad;
        }

        /// <summary>
        /// Method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            string truckInfo = base.GetInfo();
            return (truckInfo + $"Maximun load: {MaximumLoad}");
        }
    } 
}
