using System;

namespace DEV_2._1
{
    class CommandRunner
    {
        Invoker invoker = new Invoker();
        CarData carData = CarData.getInstance();

        public void RunCommands(string command)
        {
            if (command == "count all")
            {
                invoker.AddCommand(new CountAllCommand(carData));
            }
            if (command == "count types")
            {
                invoker.AddCommand(new CountTypesCommand(carData));
            }
            if (command == "average price")
            {
                invoker.AddCommand(new AveragePriceCommand(carData));
            }
            if (command == "average price type")
            {
                invoker.AddCommand(new AveragePriceTypeCommand(carData));
            }
            if(command == "run commands")
            {
                invoker.RunCommands();
            }
        }
    }
}
