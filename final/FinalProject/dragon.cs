using System;

public class Dragon : Enemy
{
    public Dragon() : base ()
    {
        SetName("Dragon");
        SetHp(250);
    }

    public override int GiveXp()
    {
        return 50;
    }
}