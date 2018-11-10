using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLib
{
    /// <summary>
    /// Represents opportunity to generate Fibonacci sequence
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// Generate Fibonacci sequence
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when amount haves incorrect value</exception>
        /// <param name="amount">amount of Fibonacci numbers</param>
        /// <returns>list of Fibonacci numbers</returns>
        public static List<long> FindFibonacciNumbers(int amount = 2)
        {
            if (amount < 2)
            {
                throw new ArgumentException($"Incorrect length {nameof(amount)} of sequnce ");
            }

            long firstNumber = 0;
            long secondNumber = 1;
            long sumFromTo = 0;
            List<long> result = new List<long> { firstNumber, secondNumber };
            while (result.Count < amount)
            {
                sumFromTo = checked(firstNumber + secondNumber);
                result.Add(sumFromTo);
                firstNumber = secondNumber;
                secondNumber = sumFromTo;
            }

            return result;
        }
    }
}
