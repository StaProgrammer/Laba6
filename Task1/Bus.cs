using System;

public class Bus : Vehicle
{
    public Bus() : base(40, 50)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Bus is driving on the road.");
    }
}
