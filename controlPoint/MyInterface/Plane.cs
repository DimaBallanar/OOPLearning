namespace MyInterface;

public class Plane:Transport, IFly
{
public Plane(string name,int number):base(name="Plane",number)
{
	
}
    public void FlyAway()
    {
    Console.WriteLine("Plane {Number} улетел");
    }
    void SitGround()
    {
    Console.WriteLine("Plane {Number} прилетел");
    }

	public override void Move()
	{
	Console.WriteLine("Plane {Number} летит");
	}

  
}