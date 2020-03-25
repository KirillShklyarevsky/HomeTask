using System;

namespace DEV_3
{
    /// <summary>
    /// Abstract claass vehicle base
    /// </summary>
    abstract public class VehicleBase
    {
        private Chassis _chassis;
        private Transmission _transmission;
        private Engine _engine;

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="chassis"></param>
        /// <param name="transmission"></param>
        public VehicleBase(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        /// <summary>
        /// Method that set and get value of engine field
        /// </summary>
        public Engine Engine
        {
            set
            {
                _engine = value ?? throw new ArgumentNullException();
            }
        
            get
            {
                return _engine;
            }
        }

        /// <summary>
        /// Method that set and get value of chassis field
        /// </summary>
        public Chassis Chassis
        {
            set
            {
                _chassis = value ?? throw new ArgumentNullException();
            }

            get
            {
                return _chassis;
            }   
        }

        /// <summary>
        /// Method that set and get value of transmission field
        /// </summary>
        public Transmission Transmission
        {
            set
            {
                _transmission = value ?? throw new ArgumentNullException();
            }

            get
            {
                return _transmission;
            }
        }

        /// <summary>
        /// Virtual method that returns all information about the object
        /// </summary>
        /// <returns></returns>
        virtual public string GetInfo()
        {
            return $"{_engine.GetInfo()}\n" + $"{_chassis.GetInfo()}\n" + $"{_transmission.GetInfo()}\n";
        }
    }
}
