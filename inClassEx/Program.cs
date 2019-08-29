using System;
using System.Collections.Generic;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "shoes",
                "hats",
                "shirts",
                "people"
            };

            myList.Add("computers");

            myList.Remove("hats");
            myList.Remove("shoes");

            Console.WriteLine(myList.Count);

            foreach (string thing in myList)
            {
                Console.WriteLine(thing);
            }

        }
        
    }
}
