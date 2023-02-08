namespace MyInterface;

public class Plane : Transport, IFly
{
    public Plane(string name, int number, int countseats) : base(name, number, countseats)
    {

    }

    public void Vzlet()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} улетел");
    }
    public void Posadka()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} прилетел");
    }
    public override void Move()
    {
        Console.WriteLine($"{Name} {NumberOfTransport} летит");
    }
}