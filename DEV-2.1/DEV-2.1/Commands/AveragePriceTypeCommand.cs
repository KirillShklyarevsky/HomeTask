using System;

namespace DEV_2._1
{
    class AveragePriceTypeCommand : ICommand
    {
        CarData carData;

        public void Execute()
        {
            carData.AveragePriceType();
        }

        public void Undo()
        {
        }
    }
}
