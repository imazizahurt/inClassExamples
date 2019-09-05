using System;
using System.Linq;

namespace inClassEx
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 7, 3, 7, 2, 1 };
            int total = numbers.Sum(); //Sum() is an extension method in the System.Linq namespace
                                      //Sum() is not a method of the int[] class itself

            int x = 10;

            //The in class does not have a Multiply method
            //Multiply is an extension method we wrote below
            int y = x.Multiply(99);

            //GetLastCharacter is an extension method written below
            string lastLetter = "Hello".GetLastCharacter();

            Console.WriteLine(y);

            Console.WriteLine(lastLetter);
        }


    }

    static class IntegerExtensions
    {
        public static int Multiply(this int number, int multiplyBy) => number * multiplyBy;
       
        public static string GetLastCharacter(this string str) => str[str.Length - 1].ToString(); 
      
    }
}
