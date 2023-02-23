using System;

class ListingActivity : Activity
{
    private string _name = "Listing Activity.";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    private int _duration = 0;

    private int _count = 0;

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

        Console.WriteLine("List as many responses you can to the following prompt: ");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random rnd = new Random();
        int number = rnd.Next(1, 6);

        if (number == 1)
        {
            Console.WriteLine("Who are people that you appreciate? ");
        }

        else if (number == 2)
        {
            Console.WriteLine("What are personal strengths of yours? ");
        }

        else if (number == 3)
        {
            Console.WriteLine("Who are people that you have helped this week? ");
        }

        else if (number == 4)
        {
            Console.WriteLine("When have you felt the Holy Ghost this month? ");
        }

        else
        {
            Console.WriteLine("Who are some of your personal heroes? ");
        }

        Console.Write("You may begin in: ");
        activity.CountDown();

        Console.WriteLine();

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
        }

        Console.Write("You listed ");
        Console.Write(_count);
        Console.WriteLine(" items!");
        Console.WriteLine();

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