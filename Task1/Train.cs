using System;

public class Train : Vehicle
{
    public Train() : base(100, 200)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Train is moving on rails.");
    }
}
