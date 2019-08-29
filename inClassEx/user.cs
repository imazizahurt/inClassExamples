using System;

namespace Mark8InClassExamples
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavAnimal { get; set; }
        public string FavNumber { get; set; }

        public string AnswerQuestion(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }
    }
}
