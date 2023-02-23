using System;

class ReflectionActivity : Activity
{
    private string _name = "Reflection Activity.";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    
    private int _duration = 0;

    public void Run()
    {
        Activity activity = new Activity();
        Console.Write(activity.Intro());
        Console.WriteLine(_name);
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write(activity.HowLong());

        _duration = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");

        activity.Wait();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random rnd = new Random();
        int number = rnd.Next(1, 5);

        if (number == 1)
        {
            Console.WriteLine("Think of a time when you stood up for someone else.");
        }

        else if (number == 2)
        {
            Console.WriteLine("Think of a time when you did something really difficult.");
        }

        else if (number == 3)
        {
            Console.WriteLine("Think of a time when you helped someone in need.");
        }

        else
        {
            Console.WriteLine("Think of a time when you did something truly selfless.");
        }

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        
        activity.CountDown();

        Console.Clear();

        while (startTime < futureTime)
        {
            Random random = new Random();
            int choice = random.Next(1, 5);

            if (choice == 1)
            {
                Console.Write("Why was this experience meaningful to you? ");
            }

            else if (choice == 2)
            {
                Console.Write("Have you ever done anything like this before? ");
            }

            else if (choice == 3)
            {
                Console.Write("How did you get started? ");
            }

            else
            {
                Console.Write("How did you feel when it was complete? ");
            }
            
            activity.Wait();

            startTime = startTime.AddSeconds(6);

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.Write(activity.Outro());
        Console.WriteLine();

        activity.Wait();
        Console.WriteLine();

        Console.Write(activity.Ending1());

        Console.Write(_duration);

        Console.Write(activity.Ending2());

        Console.WriteLine(_name);
        
        activity.Wait();
    }
}