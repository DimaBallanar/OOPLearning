namespace MyInterface;

public class Ship:Transport, ISwim
{
public Ship(string name,int number):base(name="корабль",number)
{
	
}
    public void SwimAway()
    {
    Console.WriteLine("корабль {Number} уплыл");
    }
    void SwimHere()
    {
    Console.WriteLine("корабль {Number} приплыл");
    }

	public override void Move()
	{
	Console.WriteLine("корабль {Number} плывет");
	}
}