using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }
    public List<Passenger> Passengers { get; } = new List<Passenger>();

    public Vehicle(int speed, int capacity)
    {
        Speed = speed;
        Capacity = capacity;
    }

    public abstract void Move();

    public void AddPassenger(Passenger passenger)
    {
        if (Passengers.Count < Capacity)
        {
            Passengers.Add(passenger);
            Console.WriteLine($"{passenger.Name} boarded the vehicle.");
        }
        else
        {
            Console.WriteLine("The vehicle is already at full capacity.");
        }
    }

    public void RemovePassenger(Passenger passenger)
    {
        if (Passengers.Contains(passenger))
        {
            Passengers.Remove(passenger);
            Console.WriteLine($"{passenger.Name} disembarked from the vehicle.");
        }
        else
        {
            Console.WriteLine($"{passenger.Name} is not on the vehicle.");
        }
    }
}
