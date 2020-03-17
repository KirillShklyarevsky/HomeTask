using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV_1;
using System;

namespace DEV_1.Tests
{
    [TestClass()]
    public class AmountOfSymbolsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckExeptionThrowIfStringIsNull()
        {
            AmountOfSymbols testString = new AmountOfSymbols();
            testString.AmountOfNonRepeatingSymbolsInARow(null);
        }

        [DataRow("", 0)]
        [DataRow("abccefgh", 5)]
        [DataRow("aaaaa", 1)]
        [TestMethod()]
        public void AmountOfNonRepeatingSymbolsInARowTest(string line, int expected)
        {
            AmountOfSymbols testString = new AmountOfSymbols();

            int actual = testString.AmountOfNonRepeatingSymbolsInARow(line);

            Assert.AreEqual(actual, expected);
        }
    }
}