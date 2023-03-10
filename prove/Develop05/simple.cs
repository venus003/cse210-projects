using System;

public class Simple : Goal
{
    private int _score;

    public Simple(string name, string desc, int score, bool isDone, int howMany, int bonus, int count) : base (name, desc, isDone, howMany, bonus, count)
    {
        _score = score;
    }

    public override int GetScore()
    {
        return _score;
    }

    public override string GetStringRepresentation()
    {
        string x = " ";
        if (GetDone())
        {
            x = "X";
        }
        return "[" + x + "] " + GetName() + " (" + GetDesc() + ")";
    }

    public override string Save()
    {
        return "Simple:" + GetName() + "," + GetDesc() + "," + GetScore() + "," + GetDone();
    }
}