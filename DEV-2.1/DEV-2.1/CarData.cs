using System;
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
            _xCarData = XDocument.Load(path);
        }

        public static CarData getInstance()
        {
            if (instance == null)
            {
                instance = new CarData();
            }
            return instance;
        }

        public void AddCar(Car car)
        {
           
        
        }

        public void CountAll()
        {
            int carsNumber = 0;
            foreach (XElement car in _xCarData.Root.Elements())
            {
                carsNumber += Convert.ToInt32(car.Element("vehicleNumber"));
            }
            Console.WriteLine($"Number of all cars: {carsNumber}");
        }

        public int CountTypes()
        {
            List<string> CarMakeList = new List<string>();
            int carAmount = Convert.ToInt32(excel.ReadCell(0, 0));
            for (int i = 1; i < carAmount; i++)
            {
                CarMakeList.Add(excel.ReadCell(i, 0));
            }
            return CarMakeList.Distinct().Count();
        }

        public double AveragePrice()
        {
            List<double> CarPriceList = new List<double>();
            int carAmount = Convert.ToInt32(excel.ReadCell(0, 0));
            for (int i = 1; i < carAmount; i++)
            {
                CarPriceList.Add(Convert.ToDouble(excel.ReadCell(i, 3)));
            }
            return CarPriceList.Average();
        }

        public double AveragePriceMake(string make)
        {
            List<double> CarAveragePriceMakeList = new List<double>();
            int carAmount = Convert.ToInt32(excel.ReadCell(0, 0));
            for (int i = 1; i < carAmount; i++)
            {
                CarPriceList.Add(Convert.ToDouble(excel.ReadCell(i, 3)));
            }
            brand = brand.ToLower();
            return CarsList.Where(x => x.Brand.ToLower() == brand).Average(x => x.UnitPrice);
        }
    }
}

//public CarData()
        //{
        //    Console.WriteLine("Make of the car:");
        //    Make = Console.ReadLine();
        //    Console.WriteLine("Model of the car:");
        //    Model = Console.ReadLine();
        //    Console.WriteLine("Vehicle number of the car:");
        //    VehicleNumber = Console.ReadLine();
        //    Console.WriteLine("Price of the car:");
        //    Price = Console.ReadLine();
        //}