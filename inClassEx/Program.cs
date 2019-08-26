using System;
using System.Collections.Generic;

namespace inClassEx
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Calling a method that then calls another method
            AskNumericQuestionThenDisplayTotal("What's your favorite number?");
            AskNumericQuestionThenDisplayTotal("What's your favorite year?");
        }

        static int AddNumberFrom1toN(int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total = total + i;
            }
            return total;
        }

        static void AskNumericQuestionThenDisplayTotal(string question)
        {
            Console.WriteLine(question);
            string responseAsString = Console.ReadLine();
            int response = int.Parse(responseAsString);

            //Calling another method we created.
            int total = AddNumberFrom1toN(response);
            Console.WriteLine("If you add all numbers from 1-" + response + "the total is " + total);
        }
    }
}
