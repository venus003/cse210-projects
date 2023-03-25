using System;

public abstract class Player
{
    private string _name;
    private int _hp;
    private int _xp;
    private int _level;

    public Player(string name)
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

    public void SetXp(int xp)
    {
        _xp = xp;
    }

    public int GetXp()
    {
        return _xp;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public int GetLevel()
    {
        return _level;
    }

    public abstract int MaxHp();

    public abstract void LevelUp();
}