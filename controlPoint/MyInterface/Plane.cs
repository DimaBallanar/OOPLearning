namespace MyInterface;

public class Plane : Transport, IFly
{
    public Plane(string name, int number) : base(name, number)
    { }
    public void FlyAway()
    {
        Console.WriteLine($"Plane {Name} {Number} улетел");
    }
    public void SitGround()
    {
        Console.WriteLine($"Plane  {Name} {Number} прилетел");
    }

    public override void Move()
    {
        Console.WriteLine($"Plane {Name} {Number} летит");
    }


}