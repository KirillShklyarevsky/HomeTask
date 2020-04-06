using System;
using System.Collections.Generic;

namespace DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<VehicleBase> vehicles = new List<VehicleBase>();

            var carAutoPetrolBuilder = new BuildCarAutoPetrol();
            var carManualBuilder = new BuildCarManual();
            var bus45SeatsBuilder = new BuildBus45Seats();
            var truckAutoBuilder = new BuildTruckAuto();

            vehicles.Add(carAutoPetrolBuilder.BuildVehicle());
            vehicles.Add(carAutoPetrolBuilder.BuildVehicle());
            vehicles.Add(carManualBuilder.BuildVehicle());
            vehicles.Add(carManualBuilder.BuildVehicle());
            vehicles.Add(carManualBuilder.BuildVehicle());
            vehicles.Add(bus45SeatsBuilder.BuildVehicle());
            vehicles.Add(bus45SeatsBuilder.BuildVehicle());
            vehicles.Add(truckAutoBuilder.BuildVehicle());
            vehicles.Add(truckAutoBuilder.BuildVehicle());
        }
    }
}
