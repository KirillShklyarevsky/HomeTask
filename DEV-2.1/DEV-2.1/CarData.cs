using System;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarData
    {
        private static CarData instance;
        private XDocument _xCarData;
        public const string path = @"C:\Users\MSD\source\HomeTask\DEV-2.1\DEV-2.1\CarDatabase.xml";

        private CarData()
        {
        }

        public static CarData getInstance()
        {
        }

        public int CountTypes()
        {
        }

        public int CountAll()
        {
        }

        public double AveragePrice()
        {
        }

        public double AveragePriceType()
        {
        }

        public void Exit()
        {
        }
    }
}