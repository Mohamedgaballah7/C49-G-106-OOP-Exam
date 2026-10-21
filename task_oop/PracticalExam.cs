using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time) : base(time)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");

            foreach (Question question in Questions)
            {
                question.ShowQuestion();

                Console.WriteLine(
                    $"Right Answer ID: {question.RightAnswerId}"
                );
            }
        }
    }
}
