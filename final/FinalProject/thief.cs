using System;

public class Thief : Player
{
    public Thief(string name) : base (name)
    {
        SetHp(100);
        SetLevel(1);
    }

    public override int MaxHp()
    {
        return 100;
    }
    
    public override void LevelUp()
    {
        SetHp(MaxHp());
        SetLevel(GetLevel() + 1);
    }
}