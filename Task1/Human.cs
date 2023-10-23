using System;

public class Human
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Human(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"{Name} is moving on foot.");
    }
}
