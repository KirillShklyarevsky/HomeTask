using System;

namespace DEV_1
{
    /// <summary>
    /// Class that contain method for calculating amount of different symbols in a row
    /// </summary>
    public class AmountOfSymbols
    {
        /// <summary>
        /// Method for calculating amount of different symbols in a row
        /// </summary>
        /// <param name="line"> testing string </param>
        /// <returns> Maximum amount of different symbols in a row </returns>
        public int AmountOfNonRepeatingSymbolsInARow(string line)
        {
            if (line == null)
            {
                throw new ArgumentException();
            }

            int amount = 0;
            int maxAmount = 0;
            char previousSymbol;

            if (line != String.Empty)
            {
                previousSymbol = line[0];
                foreach (char currentSymbol in line)
                {
                    if (currentSymbol != previousSymbol)
                    {
                        amount++;
                        previousSymbol = currentSymbol;
                    }
                    else
                    {
                        amount = 1;
                        previousSymbol = currentSymbol;
                    }

                    if (amount > maxAmount)
                    {
                        maxAmount = amount;
                    }
                }
                return maxAmount;
            }
            return 0;
        }
    }
}
