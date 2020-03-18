using System;

namespace DEV_2
{
    public class NumeralSystem
    {
        private int _number;
        private int _systemBase;

        public NumeralSystem(int number, int systemBase)
        {
            Number = number;
            SystemBase = systemBase;
        }

        public int Number
        {
            set
            {
                CheckNumber(value);
                _number = value;
            }

            get
            {
                return _number;
            }
        }

        public int SystemBase
        {
            set
            {
                CheckSystemBase(value);
                _systemBase = value;
            }

            get
            {
                return _systemBase;
            }
        }

        public void CheckNumber(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void CheckSystemBase(int value)
        {
            if (value < 2 || value > 20)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string ConvertToNumeralSystem()
        {
            if (Number == 0)
            {
                return Number.ToString();
            }
            if (SystemBase == 10)
            {
                return Number.ToString();
            }

            string reversedNumberInBaseSystem = String.Empty;
            int residue = 0;

            while (Number > 0)
            {
                residue = Number % SystemBase;
                Number = Number / SystemBase;
                reversedNumberInBaseSystem += ConvertResidueToString(residue);
            }
            return ReverseString(reversedNumberInBaseSystem);
        }

        public string ConvertResidueToString(int residue)
        {
            string newSymbol = String.Empty;
            if (residue > 9)
            {
                string ValuesOver10 = "ABCDEFGIJI";
                return newSymbol += ValuesOver10[residue - 10];
            }
            else
            {
                return newSymbol += residue.ToString();
            }
        }

        public string ReverseString(string ReversedNumberInBaseSystem)
        {
            char[] arr = ReversedNumberInBaseSystem.ToCharArray();
            Array.Reverse(arr);

            return new String(arr);
        }
    }
}
