namespace MyInterface;

public class Ship : Transport, ISwim
{
    public Ship(string name, int number, int countSeats) : base(name, number, countSeats)
    {

    }

    public void Poplil()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} уплыл");
    }
    public void Priplil()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} приплыл");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} плывет");
    }
}