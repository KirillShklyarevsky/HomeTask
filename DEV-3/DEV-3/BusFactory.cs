using System;

namespace DEV_3
{
    class BuildBus45Seats : IVehicleFactory
    {
        int vehicleNumber = 0;
        public VehicleBase BuildVehicle()
        {
            Engine engine = new Engine(500, 10, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", 6, "Vendor");
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 1500);

            VehicleBase vehicleBase = new Bus(45, engine, chassis, transmission);
            vehicleNumber++;
            return vehicleBase;
        }
    }
}