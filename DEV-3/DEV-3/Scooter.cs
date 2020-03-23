using System;

namespace DEV_3
{
    public class Scooter : VehicleBase
    {
        private double _maximumSpeed;

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

        public Scooter(int maximumSpeed, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            MaximumSpeed = _maximumSpeed;
        }

        public override string GetInfo()
        {
            string scooterInfo = base.GetInfo();
            return (scooterInfo + $"\nMaximum speed: {MaximumSpeed}");
        }
    }
}
