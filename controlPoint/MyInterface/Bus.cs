namespace MyInterface;

public class Bus : Transport, IDrive
{

    public Bus(string name, int number) : base(name = "автобус", number)
    {

    }
    public override void Move()
    {
        Console.WriteLine($"автобус {Name} {Number} едет");
    }
    public void DriveAway()
    {
        Console.WriteLine($"автобус {Name} {Number} уехал");
    }
    public void DriveBack()
    {
        Console.WriteLine($"автобус {Number}приехал");
    }




}