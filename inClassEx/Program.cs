using System;

namespace inClassEx
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //// Making 3 separate, independent variables to
            // describe a cat, which will have to be carefully
            // tracked/juggled as the program continues

            string catName = "Oscar";
            string catColor = "brown";
            int catAge = 1;

            string catName1 = "Ted";
            string catColor2 = "blue";
            int catAge2 = 4;


            Cat catOne = new Cat();
            catOne.Name = "Hin";
            catOne.Color = "brown";
            catOne.Age = 1;

            //A different way to define catTwo
            Cat catTwo = new Cat
            {
                Name = "bud",
                Color = "orange",
                Age = 3
            };

            catOne.Meow();
            catTwo.Meow();
        }

        public class Cat
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Age { get; set; }

            public void Meow()
            {
                Console.WriteLine($"Meeeooow, I'm {Name}, the {Color} cat!");
            }
        }

    }
}
