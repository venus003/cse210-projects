using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Beholder", "Anti-magic");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment mathProbs = new MathAssignment("Nathan", "Coding", "7.3", "8-19");
        Console.WriteLine(mathProbs.GetSummary());
        Console.WriteLine(mathProbs.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Nathan", "English", "The Rise of Video Games");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}