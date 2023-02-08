namespace MyInterface;

public class Ship:Transport, ISwim
{
public Ship(string name,int number):base(name="корабль",number)
{
	
}
    public void SwimAway()
    {
    Console.WriteLine($"корабль {Name} {Number} уплыл");
    }
    public void SwimHere()
    {
    Console.WriteLine($"корабль {Name} {Number} приплыл");
    }

	public override void Move()
	{
	Console.WriteLine($"корабль {Name} {Number} плывет");
	}
}