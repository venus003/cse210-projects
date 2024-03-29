using System;
// To Do: hide hp / weak, strong attacks / you swing wide random explanations / change flow of battle
class Program
{
    static int GetRoll()
    {
        Random rnd = new Random();
        int roll = rnd.Next(1, 21);
        return roll;
    }

    static public Warrior createWarrior()
    {
        Warrior ob = new Warrior(Console.ReadLine());
        return ob;
    }

    static public Thief createThief()
    {
        Thief ob = new Thief(Console.ReadLine());
        return ob;
    }

    static public Wizard createWizard()
    {
        Wizard ob = new Wizard(Console.ReadLine());
        return ob;
    }

    

    static void Main(string[] args)
    {
        string gamestate = "menu1";
        string choice = "";
        string input = "";
        Player user = null;
        Enemy e1 = null;
        Files files = null;

        while (gamestate == "menu1")
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hero Game!");
            Console.WriteLine();
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Load game");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            string start = Console.ReadLine();

            if (start == "1")
            {
                gamestate = "menu2";
            }

            if (start == "2")
            {
                gamestate = "menu3";
            }
        }

        while (gamestate == "menu2")
        {
            Console.Clear();

            Console.WriteLine("What is your class?");
            Console.WriteLine();
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Thief");
            Console.WriteLine("3. Wizard");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's your name, adventurer?");
            gamestate = "play";
        }

        if (gamestate == "menu3")
        {
            files = new Files();
            
            gamestate = "play";
        }

        while (gamestate == "play")
        {
            if (files != null)
            {
                user = files.loadPlayer();
            }

            if (choice == "1")
            {
                user = createWarrior();
            }

            if (choice == "2")
            {
                user = createThief();
            }

            if (choice == "3")
            {
                user = createWizard();
            }
            Console.Clear();
            Console.WriteLine($"Well met, {user.GetType()} {user.GetName()}!");

            while (user.GetHp() > 0 && input != "5")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. Fight Goblin");
                Console.WriteLine("2. Fight Troll");
                Console.WriteLine("3. Fight Dragon");
                Console.WriteLine("4. Save character");
                Console.WriteLine("5. Quit");
                Console.WriteLine();
                Console.Write("Select an option from the menu: ");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "1" || input == "2" || input == "3")
                {
                    if (input == "1")
                    {
                        e1 = new Goblin();
                    }

                    if (input == "2")
                    {
                        e1 = new Troll();
                    }

                    if (input == "3")
                    {
                        e1 = new Dragon();
                    }

                    Console.WriteLine($"{e1.GetName()} vs {user.GetName()} the {user.GetType()}");
                    Console.WriteLine("Press enter to continue...");

                    Console.Write($"{e1.GetName()} is at {e1.GetHp()} hp!");
                    Console.ReadLine();
                    Console.Write($"{user.GetName()} is at {user.GetHp()} hp!");
                    Console.ReadLine();

                    while (e1.GetHp() > 0 && user.GetHp() > 0)
                    {
                        int total = 0;
                        string hit = "";
                        
                        for (int i = 0; i < user.GetLevel(); i++)
                        {
                            total += GetRoll();
                        }

                        if (total < 5)
                        {
                            hit = "weak";
                        }

                        else if (total < 10)
                        {
                            hit = "okay";
                        }

                        else if (total < 20)
                        {
                            hit = "moderate";
                        }

                        else if (total < 50)
                        {
                            hit = "amazing";
                        }

                        else if (total < 100)
                        {
                            hit = "heroic";
                        }

                        else
                        {
                            hit = "legendary";
                        }

                        Console.Write($"{user.GetName()} hit {e1.GetName()} with a {hit} attack!");
                        Console.ReadLine();

                        e1.SetHp(e1.GetHp() - total);

                        if (e1.GetHp() <= 0)
                        {
                            Console.Write($"{user.GetName()} dealt a killing blow to {e1.GetName()}.");
                            Console.WriteLine();

                            user.SetXp(e1.GiveXp() + user.GetXp());

                            if (user.GetXp() >= 100)
                            {
                                user.LevelUp();
                                user.SetXp(user.GetXp() % 100);
                                Console.WriteLine();
                                Console.WriteLine("You leveled up!");
                                Console.WriteLine();
                            }

                            Console.Write("Press enter to continue...");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else
                        {
                            int ehit = GetRoll();
                            string eword = "";

                            if (ehit < 5)
                            {
                                eword = "weak";
                            }

                            else if (ehit < 10)
                            {
                                eword = "okay";
                            }

                            else if (ehit < 15)
                            {
                                eword = "moderate";
                            }
                            else
                            {
                                eword = "amazing";
                            }

                            user.SetHp(user.GetHp() - ehit);

                            Console.Write($"{e1.GetName()} hit {user.GetName()} with a {eword} attack!");
                            Console.ReadLine();

                            if (user.GetHp() <= 0)
                            {
                                Console.WriteLine($"{e1.GetName()} is at {e1.GetHp()} hp!");
                                Console.WriteLine($"{e1.GetName()} dealt a killing blow to {user.GetName()} the {user.GetType()}.");
                            }
                        }
                    }
                }

                if (input == "4")
                {
                    files = new Files();
                    files.savePlayer(user);
                }

                if (input == "5")
                {
                    Console.Clear();
                    Console.WriteLine($"Till next time, {user.GetName()}. Farewell.");
                }

                if (user.GetHp() < 1)
                {
                    Console.WriteLine("The end.");
                }
            }

            gamestate = "";
        }
    }
}