using System;

namespace inClassEx
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavAnimal { get; set; }
        public string FavColor { get; set; }
        public int FavNumber { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }
    }
}
