using System;

namespace DEV_2._1
{
    class CountAllCommand : ICommand
    {
        CarData carData;
        public CountAllCommand(CarData newcarData)
        {
            carData = newcarData;
        }

        public void Execute()
        {
            carData.CountAll();
        }

        public void Undo()
        {
        }
    }
}