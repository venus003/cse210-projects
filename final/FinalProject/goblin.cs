using System;

public class Goblin : Enemy
{
    public Goblin() : base ()
    {
        SetName("Goblin");
        SetHp(20);
    }

    public override int GiveXp()
    {
        return 20;
    }
}