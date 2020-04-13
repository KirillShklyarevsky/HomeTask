using System;

namespace DEV_2._1
{
    class AveragePriceCommand : ICommand
    {
        public AveragePriceCommand() { } // подумать

        public void Execute()
        {
            CarData.getInstance().AveragePrice();
        }
    }
}
