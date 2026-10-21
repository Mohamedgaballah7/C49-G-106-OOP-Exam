using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark)
            : base(header, body, mark)
        {
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
