using System;

public class Troll : Enemy
{
    public Troll() : base ()
    {
        SetName("Troll");
        SetHp(75);
    }

    public override int GiveXp()
    {
        return 25;
    }
}