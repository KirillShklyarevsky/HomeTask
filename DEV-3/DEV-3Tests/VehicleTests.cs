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
    }
}