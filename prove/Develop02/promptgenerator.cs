<<<<<<< HEAD
using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string Prompt()
    {
        Random rand = new Random();
        int number = rand.Next(0, 6);
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What do you look forward to in the future?");
        return _prompts[number];
    }
=======
using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string Prompt()
    {
        Random rand = new Random();
        int number = rand.Next(0, 6);
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What do you look forward to in the future?");
        return _prompts[number];
    }
>>>>>>> 96282d99cf3e6cd5990889a6c620eb010ba626e3
}