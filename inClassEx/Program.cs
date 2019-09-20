using System;

namespace Practice_Method
{
    class Program
    {
    
        static void Main(string[] args)
        {
            //DivideByZero Exception

            int num1 = 800;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1/num2);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Pick a different divisor!");
            }

            //OutOfRange Exception

            int[] goodArray = { 1, 5, 7, 8, 9 };

            try
            {
                Console.WriteLine(goodArray[5]);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }

    }
}