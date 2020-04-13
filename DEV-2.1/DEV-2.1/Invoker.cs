using System;
using System.Collections.Generic;

namespace DEV_2._1
{
    class Invoker
    {
        private List<ICommand> commands;

        public Invoker()
        {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void RunCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
