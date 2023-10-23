class Program
{
    static void Main(string[] args)
    {
        TransportNetwork network = new TransportNetwork();
        Car car = new Car();
        Bus bus = new Bus();
        Train train = new Train();

        network.AddVehicle(car);
        network.AddVehicle(bus);
        network.AddVehicle(train);

        Passenger stanislav = new Passenger("Stanislav", 3);
        Passenger bogdan = new Passenger("Bogdan", 7);

        car.AddPassenger(stanislav);
        bus.AddPassenger(bogdan);

        car.RemovePassenger(stanislav);
        car.RemovePassenger(bogdan);

        network.MoveAllVehicles();
    }
}
