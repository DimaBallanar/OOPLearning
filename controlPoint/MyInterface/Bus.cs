namespace MyInterface;

public class Bus : Transport, IBus
{
    public Bus(string name, int number, int countSeats) : base(name, number, countSeats)
    {

    }

    public void Poehal()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} уехал");
    }
    public void Priehal()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} приехал");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} едет");
    }
}