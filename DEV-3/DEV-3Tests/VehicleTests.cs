using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_3;
using System;

namespace DEV_3.Tests
{
    [TestClass()]
    public class VehicleTests
    {
        [DataRow(-1, 100, "Diesel", "1106D-E66TA")]
        [DataRow(100, -1, "Diesel", "1106D-E66TA")]
        [DataRow(100, 10, "", "1106D-E66TA")]
        [DataRow(100, 10, null, "1106D-E66TA")]
        [DataRow(100, 10, "Diesel", "")]
        [DataRow(100, 10, "Diesel", null)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void EngineThrowExceptionIfArgumetsNotValid(double power, double capacity, string engineType, string serialNumber)
        {
            Engine engine = new Engine(power, capacity, engineType, serialNumber);
        }

        [DataRow(-1, "QSB4-5", 1000)]
        [DataRow(4, "QSB4-5", -1)]
        [DataRow(4, "", 1000)]
        [DataRow(4, null, 1000)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ChassisThrowExceptionIfArgumetsNotValid(double numberOfWheels, string serialNumber, double permissibleLoad)
        {
            Chassis chassis = new Chassis(numberOfWheels, serialNumber, permissibleLoad);
        }

        [DataRow("Hydromechanical", 0, "Jatco")]
        [DataRow("", 5, "Jatco")]
        [DataRow(null, 5, "Jatco")]
        [DataRow("Hydromechanical", 5, "")]
        [DataRow("Hydromechanical", 5, null)]
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TransmissonThrowExceptionIfArgumetsNotValid(string transmissionType, int numberOfGears, string manufacture)
        {
            Transmission transmission = new Transmission(transmissionType, numberOfGears, manufacture);
        }
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarThrowExceptionIfArgumetsNotValid()
        {
            Engine engine = new Engine(100, 100, "Diesel", "1106D-E66TA");
            Chassis chassis = new Chassis(4, "QSB4-5", 1000);
            Transmission transmission = new Transmission("Hydromechanical", 5, "Jatco");
            Car car = new Car(0, engine, chassis, transmission);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TruckThrowExceptionIfArgumetsNotValid()
        {
            Engine engine = new Engine(1000, 10000, "Diesel", "1106D-E66TA");
            Chassis chassis = new Chassis(8, "QSB4-5", 10000);
            Transmission transmission = new Transmission("Hydromechanical", 6, "Jatco");
            Truck truck = new Truck(-1, engine, chassis, transmission);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void BusThrowExceptionIfArgumetsNotValid()
        {
            Engine engine = new Engine(1000, 10000, "Diesel", "1106D-E66TA");
            Chassis chassis = new Chassis(8, "QSB4-5", 10000);
            Transmission transmission = new Transmission("Hydromechanical", 6, "Jatco");
            Bus bus = new Bus(0, engine, chassis, transmission);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ScooterThrowExceptionIfArgumetsNotValid()
        {
            Engine engine = new Engine(10, 100, "Diesel", "1106D-E66TA");
            Chassis chassis = new Chassis(2, "QSB4-5", 100);
            Transmission transmission = new Transmission("Hydromechanical", 3, "Jatco");
            Scooter scooter = new Scooter(-10, engine, chassis, transmission);
        }
    }
}