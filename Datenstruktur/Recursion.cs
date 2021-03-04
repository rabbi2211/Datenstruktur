using System;

namespace Datenstruktur
{
    public class Recursion
    {
       /// <summary>
       /// Checks whether elements in the array are in sequnce using recursion
       /// </summary>
       /// <param name="input"></param>
       /// <param name="index"></param>
       /// <returns>bool</returns>
        public bool ElementsInSequence_Recursive(int[] input, int index)
        {
            return index == input.Length - 1 || (input[index] == input[index + 1] - 1 && ElementsInSequence_Recursive(input, index + 1));

        }
        /// <summary>
        /// Find the Sum of the digits in recursive manner
        /// </summary>
        /// <param name="number"></param>
        /// <returns>int</returns>
        public int DigitSum_Recursive(int number)
        {
            if (number == 0) return 0;
            int digit = number % 10;
            return digit + DigitSum_Recursive(number / 10);
        }
        /// <summary>
        /// Find the nth fibbonacci number using recursion
        /// </summary>
        /// <param name="number"></param>
        /// <returns>long</returns>
        public long FibonacciSeries_Recursive(int number)
        {
            if (number < 2) return 1;
            return (FibonacciSeries_Recursive(number - 1)+ FibonacciSeries_Recursive(number - 2));
        }
    }
}
