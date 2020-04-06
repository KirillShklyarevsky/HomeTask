using System;

namespace DEV_3
{
    class BuildTruckAuto : IVehicleFactory
    {
        int vehicleNumber = 0;
        public VehicleBase BuildVehicle()
        {
            Engine engine = new Engine(700, 16, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", 5, "Vendor");
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 1500);

            VehicleBase vehicleBase = new Truck(4, engine, chassis, transmission);
            vehicleNumber++;
            return vehicleBase;
        }
    }
}
