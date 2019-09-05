using System;
using System.Linq;

namespace inClassEx
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 7, 3, 7, 2, 1 };
            int total = numbers.Sum();

            int x = 10;

            int y = x.Multiply(99);

            string lastLetter = "Hello".GetLastCharacter();

            Console.WriteLine(y);

            Console.WriteLine(lastLetter);
        }


    }

    static class IntegerExtensions
    {
        public static int Multiply(this int number, int multiplyBy)
        {
            return number * multiplyBy;
        }

        public static string GetLastCharacter(this string str)
        {
            return str[str.Length - 1].ToString();
        }
    }





    
}
