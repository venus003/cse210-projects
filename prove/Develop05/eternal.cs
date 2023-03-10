using System;

public class Eternal : Goal
{
    private int _score;

    public Eternal(string name, string desc, int score, bool isDone, int howMany, int bonus, int count) : base (name, desc, isDone, howMany, bonus, count)
    {
        _score = score;
    }

    public override int GetScore()
    {
        return _score;
    }

    public override string GetStringRepresentation()
    {
        return "[ ] " + GetName() + " (" + GetDesc() + ")";
    }

    public override string Save()
    {
        return "Eternal:" + GetName() + "," + GetDesc() + "," + GetScore() + "," + GetDone();
    }
}