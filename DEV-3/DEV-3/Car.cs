using System;

namespace DEV_3
{
    public class Car : VehicleBase
    {
        private int _numberOfDoors;

        public int NumberOfDoors
        {
            set
            {
                _numberOfDoors = value;
            }

            get
            {
                return _numberOfDoors;
            }
        }

        public Car(int numberOfDoors, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string GetInfo()
        {
            string carInfo = base.GetInfo();
            return (carInfo + $"\nNumber of doors: {NumberOfDoors}");
        }
    }
}
