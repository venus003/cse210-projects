using System;

public abstract class Goal
{
    private string _name;
    private string _desc;
    private bool _isDone;
    private int _howMany;
    private int _bonus;
    private int _count;

    public Goal(string name, string desc, bool isDone, int howMany, int bonus, int count)
    {
        _name = name;
        _desc = desc;
        _isDone = isDone;
        _howMany = howMany;
        _bonus = bonus;
        _count = count;
    }

    public void SetGoal(string name, string desc, bool isDone)
    {
        _name = name;
        _desc = desc;
        _isDone = isDone;
    }

    public void Change()
    {
        _isDone = true;
    }

    public int GetHowMany()
    {
        return _howMany;
    }

    public void AddCount()
    {
        _count += 1;
    }

    public int GetCount()
    {
        return _count;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public bool GetDone()
    {
        return _isDone;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _desc;
    }

    public abstract int GetScore();

    public abstract string GetStringRepresentation();

    public abstract string Save();
}