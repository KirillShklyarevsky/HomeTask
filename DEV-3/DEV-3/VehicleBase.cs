using System;

namespace DEV_3
{
    public class VehicleBase
    {
        private Chassis _chassis;
        private Transmission _transmission;
        private Engine _engine;

        public VehicleBase(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        public Engine Engine
        {
            get
            {
                return _engine;
            }

            set
            {
                _engine = value;
            }
        }

        public Chassis Chassis
        {
            get
            {
                return _chassis;
            }

            set
            {
                _chassis = value;
            }
        }

        public Transmission Transmission
        {
            get
            {
                return _transmission;
            }

            set
            {
                _transmission = value;
            }
        }

        virtual public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" + $"{_chassis.GetInfo()}\n" + $"{_transmission.GetInfo()}\n";
        }
    }
}
