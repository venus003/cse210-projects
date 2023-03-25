using System;

public abstract class Enemy
{
    private string _name;
    private int _hp;

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetHp(int hp)
    {
        _hp = hp;
    }

    public int GetHp()
    {
        return _hp;
    }

    public abstract int GiveXp();
}