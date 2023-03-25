using System;

public class Files
{
    public void savePlayer(Player user)
    {
        Console.Write("Name the save file: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{user.GetType()}");
            outputFile.WriteLine($"{user.GetName()}");
            outputFile.WriteLine($"{user.GetHp()}");
            outputFile.WriteLine($"{user.GetXp()}");
            outputFile.WriteLine($"{user.GetLevel()}");
        }
        Console.Clear();
    }

    public Player loadPlayer()
    {
        Console.Clear();
        
        Console.Write("What is the file name? ");
        string filename = Console.ReadLine();
        Console.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);

        string what = lines[0];
        string name = lines[1];
        int hp = Convert.ToInt32(lines[2]);
        int xp = Convert.ToInt32(lines[3]);
        int level = Convert.ToInt32(lines[4]);

        switch (what)
        {
            case "Warrior":
                Warrior warrior = new Warrior(name);
                warrior.SetHp(hp);
                warrior.SetXp(xp);
                warrior.SetLevel(level);
                return warrior;

            case "Thief":
                Thief thief = new Thief(name);
                thief.SetHp(hp);
                thief.SetXp(xp);
                thief.SetLevel(level);
                return thief;

            case "Wizard":
                Wizard wizard = new Wizard(name);
                wizard.SetHp(hp);
                wizard.SetXp(xp);
                wizard.SetLevel(level);
                return wizard;

            default:
                return null;
        }
    }
}