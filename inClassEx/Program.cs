using System;

namespace inClassEx
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //The long way that can be made easier with arrays
            string name01 = "Hunter";
            string name02 = "Bailey";
            string name03 = "Piper";
            string name04 = "Smith";
            string name05 = "Adam";

            Console.WriteLine(name01);

            string[] names = new string[5];

            names[0] = "Hunter";
            names[4] = "Bailey";
            names[2] = "Piper";
            names[3] = "Smith";
            names[1] = "Adam";

            foreach (var person in names)
            {
                Console.WriteLine(person);
            }

            string[] cars = new string[3] { "honda", "toyota", "chevy" };

            foreach (var c in cars)
            {
                Console.WriteLine(c);
            }

            int[] grades = new int[3] { 98, 89, 77 };

            foreach (int g in grades)
            {
                Console.WriteLine(g);
            }

            



            
        }

        

    }
}
