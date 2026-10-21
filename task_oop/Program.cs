namespace task_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");

            FinalExam exam = new FinalExam(60);

            TrueFalseQuestion q1 = new TrueFalseQuestion(
                "Q1",
                "C# is an OOP language?",
                5
            );

            q1.RightAnswerId = 1;

            MCQQuestion q2 = new MCQQuestion(
                "Q2",
                "Which language is used with .NET?",
                5
            );

            q2.Answers.Add(new Answer(1, "C#"));
            q2.Answers.Add(new Answer(2, "HTML"));
            q2.Answers.Add(new Answer(3, "CSS"));

            q2.RightAnswerId = 1;

            exam.Questions.Add(q1);
            exam.Questions.Add(q2);

            subject.CreateExam(exam);

            Console.WriteLine($"Subject: {subject.SubjectName}");
            Console.WriteLine($"Exam Time: {subject.Exam.Time}");

            subject.Exam.ShowExam();
        }
    }
}
