using System;

namespace DEV_3
{
    class BuildCarAutoPetrol : IVehicleFactory
    {
        int vehicleNumber = 0;
        public VehicleBase BuildVehicle()
        {
            Engine engine = new Engine(200, 3, "Petrol", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Automatic", 5, "Vendor");
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 1500);

            VehicleBase vehicleBase = new Car(4, engine, chassis, transmission);
            vehicleNumber++;
            return vehicleBase;
        }
    }

    class BuildCarManual : IVehicleFactory
    {
        int vehicleNumber = 0;
        public VehicleBase BuildVehicle()
        {
            Engine engine = new Engine(200, 3.2, "Disel", "Serial" + vehicleNumber);
            Transmission transmission = new Transmission("Manual", 5, "Vendor");
            Chassis chassis = new Chassis(4, "Serial" + vehicleNumber, 1500);

            VehicleBase vehicleBase = new Car(4, engine, chassis, transmission);
            vehicleNumber++;
            return vehicleBase;
        }
    }
}
