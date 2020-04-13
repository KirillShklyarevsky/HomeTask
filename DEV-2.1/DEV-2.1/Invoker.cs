using System;
using System.Collections.Generic;

namespace DEV_2._1
{
    class Invoker
    {
        //List<ICommand> commands = new List<ICommand>;

        ICommand _command;

        public Invoker() { }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void Run()
        {
            _command.Execute();
        }
        public void Cancel()
        {
            _command.Undo();
        }
    }
}
