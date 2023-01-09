using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 101);
        int guess = -1;
        while (answer != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (answer == guess)
            {
                Console.Write("You guessed it!");
            }
            else if (answer < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (answer > guess)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}
