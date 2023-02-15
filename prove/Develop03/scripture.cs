using System;

public class Scripture
{   
    private string here;
    
    private int length = 25;

    private int count = 0;

    private List<string> _verse = new List<string>();

    private List<bool> _isHidden = new List<bool>();

    public void Read()
    {
        string file = "passages.txt";

        string[] lines = System.IO.File.ReadAllLines(file);

        string[] words = lines[0].Split(' ');

        foreach (string word in words)
        {
            _verse.Add(word);
        }
    }

    public void Display()
    {
        while(count < length)
        {
            _isHidden.Add(false);
            count++;
        }

        for(int i=0; i < 25; i++)
        {
            if(_isHidden[i])
            {
                foreach (char letters in _verse[i])
                {
                    here += "_";
                }

                Console.Write(here);
                Console.Write(" ");
                here = "";
            }
            else
            {
                Console.Write($"{_verse[i]} ");
            }
        }
    }

    public void Hide()
    {
        Random rnd = new Random();

        for(int i=0; i < 25; i++)
        {
            int number = rnd.Next(1, 3);
            if(number == 1)
            {
                _isHidden[i] = true;
            }
        }
    }
}