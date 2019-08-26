using System;
using System.Collections.Generic;

namespace inClassEx
{
    class Program
    {
        static bool ContainsAtLeastTwoEvenNumbers(List<int> numbers)
        {
            int countOfEvens = 0;
            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    countOfEvens += 1;
                }

                if(countOfEvens >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        static int SumArray(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }

            return total;
        }

        static bool ContainsAnEight(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if(number == 8)
                {
                    return true;
                }
            }

            return false;

        }






        static void Main(string[] args)
        {
          
        }

        
    }
}
