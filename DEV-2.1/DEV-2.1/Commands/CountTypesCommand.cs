using System;

namespace DEV_2._1
{
    class CountTypesCommand : ICommand
    {
        CarData carData;

        public void Execute()
        {
            carData.CountTypes();
        }
        
        public void Undo()
        {
        }
    }
}
