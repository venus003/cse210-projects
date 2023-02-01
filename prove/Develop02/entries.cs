using System;

public class Entries
{
    public void Fill(List<string> entries)
    {
        Console.WriteLine("What is the filename?");

        string file = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            entries.Add(line);
        }
    }
}