using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               if (args.Length < 2)
               {
                   throw new ArgumentException();
               } 

                Converter converter = new Converter();
                Console.WriteLine(converter.Convert(Convert.ToDouble(args[0]), args[1]));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect arguments");
            }

        }
    }
}