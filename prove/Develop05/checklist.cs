using System;

public class Checklist : Goal
{
    private int _score;

    public Checklist(string name, string desc, int score, bool isDone, int howMany, int bonus, int count) : base (name, desc, isDone, howMany, bonus, count)
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
        return "[" + x + "] " + GetName() + " (" + GetDesc() + ") -- Currently completed: " + GetCount() + "/" + GetHowMany();
    }

    public override string Save()
    {
        return "Checklist:" + GetName() + "," + GetDesc() + "," + GetScore() + "," + GetDone() + "," + GetHowMany() + "," + GetBonus() + "," + GetCount();
    }
}