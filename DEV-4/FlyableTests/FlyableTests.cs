using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DEV_4;

namespace FlyableTests
{
    [TestClass]
    public class FlyableTests
    {

        [TestMethod]
        [DataRow(-1, 1, 1)]
        [DataRow(1, -1, 1)]
        [DataRow(1, 1, -1)]
        [ExpectedException(typeof(ArgumentException))]
        public void CoordinateThrowExceptionTest(double x, double y, double z)
        {
            Coordinate coordinate = new Coordinate(x, y, z);
        }

        [TestMethod]
        public void DistanceBetweenTwoPointTest()
        {
            Coordinate coordinate1 = new Coordinate(0, 0, 0);
            Coordinate coordinate2 = new Coordinate(1, 1, 1);
            double expected = Math.Sqrt(3);

            double actual = coordinate1.DistanceBetweenTwoPoint(coordinate2);

            Assert.AreEqual(actual, expected);
        }
    }
}
