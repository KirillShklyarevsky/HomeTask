using System;

namespace DEV_2
{
    /// <summary>
    /// Class that contain method for conveting numbers for from decimal system to other (2-20)
    /// </summary>
    public class NumeralSystem
    {
        private int _number;
        private int _systemBase;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="number"> Number in decimal system </param>
        /// <param name="systemBase"> Base of other system </param>
        public NumeralSystem(int number, int systemBase)
        {
            Number = number;
            SystemBase = systemBase;
        }

        /// <summary>
        /// Method which set value of the field number and returns it
        /// </summary>
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

        /// <summary>
        /// Method which set value of the field systemBase and returns it
        /// </summary>
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


        /// <summary>
        /// Check if number is greater than zero
        /// </summary>
        /// <param name="value"> checked argument </param>
        public void CheckNumber(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Check if systemBase are from 2 to 20
        /// </summary>
        /// <param name="value"> checked argument </param>
        public void CheckSystemBase(int value)
        {
            if (value < 2 || value > 20)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Method for conveting numbers for from decimal system to other (2-20)
        /// </summary>
        /// <returns> Converted to string number in new numeral system </returns>
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

        /// <summary>
        /// Method converting residue to equivalent number
        /// </summary>
        /// <param name="residue"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method reverse strings
        /// </summary>
        /// <param name="ReversedNumberInBaseSystem"> non reversed string </param>
        /// <returns> Reversed string </returns>
        public string ReverseString(string ReversedNumberInBaseSystem)
        {
            char[] arr = ReversedNumberInBaseSystem.ToCharArray();
            Array.Reverse(arr);

            return new String(arr);
        }
    }
}
