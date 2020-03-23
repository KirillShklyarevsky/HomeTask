using System;

namespace DEV_3
{
    public class Bus : VehicleBase
    {
        private int _seatsNumber;

        public int SeatsNumber
        {
            set
            {
                _seatsNumber = value;
            }

            get
            {
                return _seatsNumber;
            }
        }

        public Bus(int seatsNumber, Engine engine, Chassis chassis, Transmission transmission)
        : base(engine, chassis, transmission)
        {
            SeatsNumber = _seatsNumber;
        }

        public override string GetInfo()
        {
            string busInfo = base.GetInfo();
            return (busInfo + $"\nNumber of seats: {SeatsNumber}");
        }
    }
}