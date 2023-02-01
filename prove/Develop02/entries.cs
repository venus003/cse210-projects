<<<<<<< HEAD
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
=======
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
>>>>>>> 96282d99cf3e6cd5990889a6c620eb010ba626e3
}