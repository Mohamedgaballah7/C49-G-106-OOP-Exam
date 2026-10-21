using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public class FinalExam : Exam
    {
        public FinalExam(int time) : base(time)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");

            foreach (Question question in Questions)
            {
                question.ShowQuestion();
            }
        }
    }
}
