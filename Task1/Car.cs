using System;

public class Car : Vehicle
{
    public Car() : base(60, 5)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Car is driving on the road.");
    }
}
