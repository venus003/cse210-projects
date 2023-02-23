using System;

class Activity
{
    private string _startMsg = "Welcome to the ";
    private string _endMsg = "Well done!";
    private string _durationMsg = "How long, in seconds, would you like for your session? ";

    public string Intro()
    {
        return _startMsg;
    }

    public string HowLong()
    {
        return _durationMsg;
    }

    public void Wait()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(6);

        while (startTime < futureTime)
        {
            Console.Write("―");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

            startTime = startTime.AddSeconds(2);
        }
    }

    public void CountDown()
    {
        int num = 5;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(num);

        while (startTime < futureTime)
        {
            Console.Write(num);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            startTime = startTime.AddSeconds(1);
            num = num - 1;
        }
    }

    public string Outro()
    {
        return _endMsg;
    }

    public string Ending1()
    {
        return "You have completed another ";
    }

    public string Ending2()
    {
        return " seconds of the ";
    }
}