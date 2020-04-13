using System;

namespace DEV_2._1
{
    class Car
    {
        private const int minimalVehicleNumber = 0;
        private const int minimalPrice = 0;
        private string _make;
        private string _model;
        private int _vehicleNumber;
        private int _price;

        public Car(string make, string model, int vehicleNumber, int price)
        {
            Make = make;
            Model = model;
            VehicleNumber = vehicleNumber;
            Price = price;
        }


        public string Make
        {
            get
            {
                return _make;
            }

            set
            {
                CheckStringValue(value);
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                CheckStringValue(value);
                _model = value;
            }
        }

        public int VehicleNumber
        {
            get
            {
                return _vehicleNumber;
            }

            set
            {
                if (value < minimalVehicleNumber)
                {
                    throw new ArgumentException();
                }
                _vehicleNumber = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            
            set
            {
                if (value < minimalPrice)
                {
                    throw new ArgumentException();
                }
                _price = value;
            }
        }

        public void CheckStringValue(string value)
        {
            if (value == string.Empty || value == null)
            {
                throw new ArgumentException();
            }
        }
    }
}