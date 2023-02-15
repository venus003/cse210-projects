using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Scripture scripture1 = new Scripture();
        scripture1.Read();
        while (input == "")
        {
            Console.Clear();
            scripture1.Display();
            scripture1.Hide();
            input = Console.ReadLine();
        }
        Console.Clear();
    }
}