using System;

namespace DEV_2._1
{
    class Car
    {
        public string Make { set; get; }
        public string Model { set; get; }
        public string VehicleNumber { set; get; }
        public string Price { set; get; }

        public Car(string make, string model, string vehicleNumber, string price)
        {
            Make = make;
            Model = model;
            VehicleNumber = vehicleNumber;
            Price = price;
        }
    }
}
