
using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!");
            Console.WriteLine("What max value would you like to use?");
            string strMax = Console.ReadLine();
            int max = int.Parse(strMax);

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            int guess;
            do
            {
                Console.ResetColor();
                Console.WriteLine("Please guess a number between 1-" + max + ":");

                string strGuess = Console.ReadLine();
                guess = int.Parse(strGuess);
                //also could do: int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You're not wrong!");
                }

                else if (guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You die...Too High! LOSER!");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're slow...Too Low! LOSER!");
                }
            } while (guess != secretNumber);
        }
        
         
        
    }
}