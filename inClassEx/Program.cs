using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of two numbers:" + MultDisplay(5, 2));

            Console.WriteLine("Multiplication of two numbers:" + MultDisplay(8, 2, 12));

            Console.WriteLine("Multiplication of two numbers:" + MultDisplay(2.2, 6.7));

            Console.WriteLine("Multiplication of two numbers:" + MultDisplay(6, 2, 7, 0));

        }

        public static int MultDisplay(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int MultDisplay(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static double MultDisplay(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int MultDisplay(int num1, int num2, int num3, int num4)
        {
            return num1 * num2 * num3 * num4;
        }
        
    }
}
