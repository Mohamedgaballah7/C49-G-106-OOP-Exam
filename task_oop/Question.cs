using System;
using System.Collections.Generic;
using System.Text;

namespace task_oop
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public int RightAnswerId { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new List<Answer>();
        }

        public abstract void ShowQuestion();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            return Mark.CompareTo(other.Mark);
        }
    }
}
