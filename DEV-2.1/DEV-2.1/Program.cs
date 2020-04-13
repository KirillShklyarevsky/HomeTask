using System;

namespace DEV_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            while (true)
            {
                CommandRunner commandRunner = new CommandRunner();

                Console.WriteLine("Write command: ");
                command = Console.ReadLine();
                if (command == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    commandRunner.RunCommands(command);
                }
            }
        }
    }
}
