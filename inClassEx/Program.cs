using System;
using System.Collections.Generic;

namespace inClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Hey, Can I ask you a little about yourself?");

            user.FirstName = user.AnswerQuestion("What's your first name?");
            user.LastName = user.AnswerQuestion("What's your last name?");
            user.FavAnimal = user.AnswerQuestion("What's your favorite animal?");
            user.FavColor = user.AnswerQuestion("How about your favorite color...");
            user.FavNumber = user.AnswerQuestionWithInteger("What's your lucky number?");

            Console.WriteLine($"So, you are {user.FirstName} {user.LastName}, and your favorite color is {user.FavColor}!");
            Console.WriteLine($"Your spirit animal is {user.FavAnimal}!");

            Console.Write($"And your lucky number is");

            if(user.FavNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{user.FavNumber}");
                Console.ForegroundColor = ConsoleColor.Black;
            }

            else if(user.FavNumber < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{user.FavNumber}");
                Console.ForegroundColor = ConsoleColor.Black;
            }


        }

        
    }
}
