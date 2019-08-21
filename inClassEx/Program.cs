using System;
using System.Collections.Generic;

namespace inClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //for

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //foreach

            string[] names = { "Smith", "Piper", "Adam", "Hunter", "Bailey" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //while

            string userResponse = "no";
            while(userResponse != "yes")
            {
                Console.WriteLine("Please say yes!!");
                userResponse = Console.ReadLine();
            }

            //do-while

            int numberForDoWhileLoop = 99;

            do
            {
                Console.WriteLine("Hey Dude!!!");
            } while (numberForDoWhileLoop < 0);

        }
    }
}
