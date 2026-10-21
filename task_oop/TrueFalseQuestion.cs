using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            foreach (Answer answer in Answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
