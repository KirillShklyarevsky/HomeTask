using System;
using System.Linq;
using System.Xml.Linq;

namespace DEV_2._1
{
    class CarData
    {
        private static CarData _instance;
        private XDocument _xCarData;
        public const string path = @"C:\Users\MSD\source\HomeTask\DEV-2.1\DEV-2.1\CarDatabase.xml";

        private CarData()
        {
            _xCarData = XDocument.Load(path);
        }

        public static CarData getInstance()
        {
            if (_instance == null)
            {
                _instance = new CarData();
            }
            return _instance;
        }

        public void CountAll()
        {
            Console.WriteLine(_xCarData.Root
                                        .Elements()
                                        .Select(element => (int)element.Element("count"))
                                        .Sum());
        }

        public void CountTypes()
        {
            Console.WriteLine(_xCarData.Root
                                        .Elements()
                                        .Select(element => element.Attribute("name").Value).Distinct()
                                        .Count());
        }

        public void AveragePrice()
        {
            Console.WriteLine(_xCarData.Root
                                        .Elements()
                                        .Select(element => (int)element.Element("cost"))
                                        .Average());
        }

        public void AveragePriceType()
        {
            string make=Console.ReadLine();
            if (_xCarData.Root
                          .Elements()
                          .Any(elememt =>elememt.Attribute("name")
                          .Value.ToLower() == make.ToLower()))
            {
                Console.WriteLine(_xCarData.Root
                                 .Elements().Where(elememt => elememt.Attribute("name")
                                 .Value.ToLower() == make.ToLower())
                                 .Select(element => (int)element.Element("cost"))
                                 .Average());
            }
        }
    }
}