using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Percentage: ");
        String input = Console.ReadLine();

        int gradePercent = int.Parse(input);
        string letter = "F";
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }

        Console.WriteLine(letter);
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Seems you didn't pass. You'll do better next time!");
        }
    }
}
