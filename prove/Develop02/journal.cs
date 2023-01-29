using System;

public class Journal
{
    public string _menu;

    public List<string> _entryList = new List<string>();
    
    Entries entry1 = new Entries();
    PromptGenerator prompt1 = new PromptGenerator();

    public void Display()
    {
        Console.WriteLine(_menu);
    }

    public void Write()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string p = prompt1.Prompt();

        Console.WriteLine(p);
        Console.Write("> ");
        _entryList.Add($"Date: {dateText} - Prompt: {p} {Console.ReadLine()}");
    }

    public void EntriesDisplay()
    {
        foreach (string line in _entryList)
            {
                Console.WriteLine(line);
                Console.WriteLine();
            }
    }

    public void Load()
    {
        _entryList.Clear();
        entry1.Fill(_entryList);
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");

        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string line in _entryList)
            {
                outputFile.WriteLine(line);
            }
            _entryList.Clear();
        }
    }
}