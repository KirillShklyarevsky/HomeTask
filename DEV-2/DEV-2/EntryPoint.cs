using System;

namespace DEV_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            NumeralSystem a = new NumeralSystem(263, 20);
            Console.WriteLine(a.ConvertToNumeralSystem());
        }
    }
}
