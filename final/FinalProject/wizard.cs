using System;

public class Wizard : Player
{
    public Wizard(string name) : base (name)
    {
        SetHp(75);
        SetLevel(1);
    }

    public override int MaxHp()
    {
        return 75;
    }
    
    public override void LevelUp()
    {
        SetHp(MaxHp());
        SetLevel(GetLevel() + 1);
    }
}