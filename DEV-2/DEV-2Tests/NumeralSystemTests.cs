using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_2;
using System;

namespace DEV_2.Tests
{
    [TestClass()]
    public class NumeralSystemTests
    {
        [DataRow(0, 2, "0")]
        [DataRow(222, 2, "11011110")]
        [DataRow(7, 3,"21")]
        [DataRow(7, 8,"7")]
        [DataRow(16, 8,"20")]
        [DataRow(5, 10,"5")]
        [DataRow(20, 16, "14")]
        [DataRow(666, 16, "29A")]
        [DataRow(666, 20, "1D6")]
        [DataRow(20, 20, "10")]
        [TestMethod()]
        public void ConvertToNumeralSystemTest(int number,int systemBase,string expected)
        {
            NumeralSystem system = new NumeralSystem(number, systemBase);

            string actual = system.ConvertToNumeralSystem();

            Assert.AreEqual(actual, expected);
        }

        [DataRow(5, "5")]
        [DataRow(10, "A")]
        [DataRow(19, "I")]
        [TestMethod()]
        public void ConvertResidueToStringTest(int residue,string expected)
        {
            NumeralSystem system = new NumeralSystem(10, 10);

            string actual = system.ConvertResidueToString(residue);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfCheckNumberFhrowException()
        {
            NumeralSystem system = new NumeralSystem(-10, 2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfCheckSystemBaseFhrowException()
        {
            NumeralSystem system = new NumeralSystem(10, 21);
        }
    }
}