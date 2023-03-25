using System;

public class Warrior : Player
{
    public Warrior(string name) : base (name)
    {
        SetHp(125);
        SetLevel(1);
    }

    public override int MaxHp()
    {
        return 125;
    }

    public override void LevelUp()
    {
        SetHp(MaxHp());
        SetLevel(GetLevel() + 1);
    }
}