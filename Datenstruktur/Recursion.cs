using System;

namespace Datenstruktur
{
    public class Recursion
    {
       
        public bool ElementsInSequence_Recursive(int[] input, int index)
        {
            return index == input.Length - 1 || (input[index] == input[index + 1] - 1 && ElementsInSequence_Recursive(input, index + 1));

        }

        public int DigitSum_Recursive(int number)
        {
            if (number == 0) return 0;
            int digit = number % 10;
            return digit + DigitSum_Recursive(number / 10);
        }

        public long FibonacciSeries_Recursive(int number)
        {
            if (number < 2) return 1;
            return (FibonacciSeries_Recursive(number - 1)+ FibonacciSeries_Recursive(number - 2));
        }
    }
}
