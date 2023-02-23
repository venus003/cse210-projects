using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";

        while (option != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Clear();
                BreathingActivity breathingactivity = new BreathingActivity();
                breathingactivity.Run();
            }
            else if (option == "2")
            {
                Console.Clear();
                ReflectionActivity reflectionactivity = new ReflectionActivity();
                reflectionactivity.Run();
            }

            else if (option == "3")
            {
                Console.Clear();
                ListingActivity listingactivity = new ListingActivity();
                listingactivity.Run();
            }
        }
    }
}