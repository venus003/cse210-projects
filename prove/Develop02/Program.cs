using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int input = 0;
        Journal journal1 = new Journal();
        
        while (input != 5)
        {
            journal1._menu = @"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
";
            journal1.Display();
            Console.Write("What would you like to do? ");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                journal1.Write();
            }
            else if (input == 2)
            {
                journal1.EntriesDisplay();
            }
            else if (input == 3)
            {
                journal1.Load();
            }
            else if (input == 4)
            {
                journal1.Save();
            }
        }
    }
}
