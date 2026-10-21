using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public List<Question> Questions { get; set; }

        public Exam(int time)
        {
            Time = time;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
    }
}
