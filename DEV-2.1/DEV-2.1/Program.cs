using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarData car = new CarData();
            car.SaveData();
            Invoker invoker = new Invoker();
            invoker.SetCommand(new CountAllCommand(car));
            invoker.Run();
        }
    }
}
