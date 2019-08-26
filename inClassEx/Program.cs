using System;
using System.Collections.Generic;

namespace inClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskQuestions("What is your name?");
            string favoriteColor = AskQuestions("What is your favorite color?");
            string favoriteCar = AskQuestions("What is your favorite car?");

            Console.WriteLine("Hey, " + name + "!");
            Console.WriteLine("Your favorite color is " + favoriteColor);
            Console.WriteLine("And your favorite car is " + favoriteCar);
        }

        static string AskQuestions(string question)
        {
            string response = "";
            while (response == "")
            {
                Console.WriteLine(question);
                response = Console.ReadLine();

            }
            return response;
        }
    }
}
