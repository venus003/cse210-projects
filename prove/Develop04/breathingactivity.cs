using System;

class BreathingActivity : Activity
{
    private string _name = "Breathing Activity.";
    private string _description = "This activity will help you relax by breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Now breathe out...";
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

        while (startTime < futureTime)
        {
            Console.Write(_breatheIn);

            activity.CountDown();

            startTime = startTime.AddSeconds(5);

            Console.WriteLine();

            Console.Write(_breatheOut);
            
            activity.CountDown();

            startTime = startTime.AddSeconds(5);

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