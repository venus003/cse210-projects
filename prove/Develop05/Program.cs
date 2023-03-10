using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Goal Tracker!");
        string input = "";
        int totalScore = 0;

        List<Goal> goals = new List<Goal>();

        while (input != "6")
        {
            Console.WriteLine($"You have {totalScore} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                string name = "";
                string desc = "";
                int score = 0;
                int howMany = 0;
                int bonus = 0;

                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string i = Console.ReadLine();

                Questions q = new Questions();
                bool isDone = false;

                if (i == "1")
                {
                    Console.WriteLine("Simple goal creation process started");
                    q.One();
                    name = Console.ReadLine();
                    q.Two();
                    desc = Console.ReadLine();
                    q.Three();
                    score = Convert.ToInt32(Console.ReadLine());
                    
                    Simple sGoal = new Simple(name, desc, score, isDone, 0, 0, 0);

                    goals.Add(sGoal);
                }
                if (i == "2")
                {
                    Console.WriteLine("Eternal goal creation process started");
                    q.One();
                    name = Console.ReadLine();
                    q.Two();
                    desc = Console.ReadLine();
                    q.Three();
                    score = Convert.ToInt32(Console.ReadLine());

                    Eternal eGoal = new Eternal(name, desc, score, isDone, 0, 0, 0);

                    goals.Add(eGoal);
                }
                if (i == "3")
                {
                    Console.WriteLine("Checklist goal creation process started");
                    q.One();
                    name = Console.ReadLine();
                    q.Two();
                    desc = Console.ReadLine();
                    q.Three();
                    score = Convert.ToInt32(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    howMany = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = Convert.ToInt32(Console.ReadLine());

                    Checklist cGoal = new Checklist(name, desc, score, isDone, howMany, bonus, 0);

                    goals.Add(cGoal);
                }
            }

            if (input == "2") //list goals
            {
                int count = 1;
                Console.WriteLine("The goals are: ");

                foreach (var info in goals)
                {
                    Console.WriteLine($"{count}. {info.GetStringRepresentation()}");
                    count++;
                }
            }

            if (input == "3") //save goals
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{totalScore}");
                    foreach (var item in goals)
                    {
                        outputFile.WriteLine($"{item.Save()}");
                    }
                }
            }

            if (input == "4") //load goals
            {
                goals.Clear();
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                totalScore = Convert.ToInt32(lines[0]);

                lines = lines.Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    string ob = parts[0];
                    string info = parts[1];

                    string[] data = info.Split(",");
                    string name = data[0];
                    string desc = data[1];
                    int score = Convert.ToInt32(data[2]);
                    bool isDone = Convert.ToBoolean(data[3]);

                    if (ob == "Simple")
                    {
                        Simple sTemp = new Simple(name, desc, score, isDone, 0, 0, 0);
                        goals.Add(sTemp);
                    }

                    if (ob == "Eternal")
                    {
                        Eternal eTemp = new Eternal(name, desc, score, isDone, 0, 0, 0);
                        goals.Add(eTemp);
                    }

                    if (ob == "Checklist")
                    {
                        int howMany = Convert.ToInt32(data[4]);
                        int bonus = Convert.ToInt32(data[5]);
                        int count = Convert.ToInt32(data[6]);

                        Checklist cTemp = new Checklist(name, desc, score, isDone, howMany, bonus, count);
                        goals.Add(cTemp);
                    }
                }
            }

            if (input == "5") //Record goal
            {
                int num = 1;
                Console.WriteLine("The goals are: ");
                
                foreach (var goal in goals)
                {
                    Console.WriteLine($"{num}. {goal.GetName()}");
                    num++;
                }

                Console.Write("Which goal did you accomplish? ");
                int option = Convert.ToInt32(Console.ReadLine());

                int points = goals[option-1].GetScore();

                if (goals[option-1].GetType().Name == "Simple")
                {
                    goals[option-1].Change();
                }

                if (goals[option-1].GetType().Name == "Checklist")
                {
                    goals[option-1].AddCount();
                    if (goals[option-1].GetCount() == goals[option-1].GetHowMany())
                    {
                        points += goals[option-1].GetBonus();
                        goals[option-1].Change();
                    }
                }

                Console.WriteLine($"Congratulations! You have earned {points} points!");
                totalScore += points;
                Console.WriteLine($"You now have {totalScore} points.");
                Console.WriteLine();
            }
        }
    }
}