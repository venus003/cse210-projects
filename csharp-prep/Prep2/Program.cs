using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Percentage: ");
        String gradePercent = Console.ReadLine();

        int.Parse(gradePercent);

        Console.Write($"{gradePercent}");
    }
}