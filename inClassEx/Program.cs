using System;
using System.Diagnostics;

namespace inClassExamples
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }

        static void GiveUserARandomInsult(string[] availableInsults)
        {
            Random random = new Random();
            int insultIndex = random.Next(0, availableInsults.Length);
            string insult = availableInsults[insultIndex];
            Console.WriteLine(insult);
        }

        static void RespondToIncorrectGuess(string[] insultsToBeUsed, string highLowHint)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(highLowHint);
            GiveUserARandomInsult(insultsToBeUsed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game!");

            int max = GetIntegerFromUser("What max range would you like?");

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);

            string[] insults = {
                "You ugly...You your daddy son!!",
                "You are quite the guesser...NOT!!!",
                "Maybe you should try a different game..Perhaps dodge the cars in traffic?",
                "Try " + (secretNumber + 1) + ". No, really, you should try " + (secretNumber +1) + "."
            };
 
            int score = 0;
            int guess;
            bool shouldLaunchVideo = true;

            do
            {
                Console.ResetColor();

                Console.WriteLine("Your current score is " + score);
                guess = GetIntegerFromUser("Please guess a number between 1-" + max + ":");


                if (guess > max || guess < 1)
                {
                    Console.WriteLine("So, apparently guessing isn't your thing");

                    if(shouldLaunchVideo == true)
                    {
                        shouldLaunchVideo = false;
                        Console.WriteLine("Heres a tutorial that's about your competence level:");

                        System.Threading.Thread.Sleep(4000);

                        // mac
                        Process.Start("open", "https://www.youtube.com/watch?v=9QDZUrvNI-0");

                        //windows
                        //Process.Start(new ProcessStartInfo("cmd", $"/c start https://www.youtube.com/watch?v=9QDZUrvNI-0"));
                    }

                    score += 10;

                }

                else 
                {
                    if(guess > secretNumber)
                    {
                        RespondToIncorrectGuess(insults, "You were too high, loser!");
                        score += 1;
                    }
                    else if(guess < secretNumber)
                    {
                        RespondToIncorrectGuess(insults, "You were too low, loser!");
                    }
                }

            } while (guess != secretNumber);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finally...you got it!!!");
            Console.WriteLine("Your final score was " + score);
            Console.WriteLine("Next time, May the odds be ever in your favor...Or whatever!!");
        }



    }
}
