using System;

namespace DEV_2._1
{
    class ExitCommand : ICommand
    {
        CarData carData;

        public void Execute()
        {
            carData.Exit();
        }

        public void Undo()
        {
        }
    }
}
