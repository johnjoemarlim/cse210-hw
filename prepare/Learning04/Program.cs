using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John", "Anatomy");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("John Lim", "Physics", "Section 7.3", "Problems 8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}