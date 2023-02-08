namespace MyInterface;

public abstract class Transport
{
    public string Name { get; set; }
    public int NumberOfTransport { get; set; }
    public int CountSeats { get; set; }

    public Transport(string name, int number, int countseats)
    {
        Name = name;
        NumberOfTransport = number;
        CountSeats = countseats;
    }

    public abstract void Move();
}