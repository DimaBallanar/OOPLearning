namespace MyInterface;

public class Bus:Transport, IDrive
{
public Bus(string name,int number):base(name="автобус",number)
{
	
}
    public void DriveAway()
    {
    Console.WriteLine($"автобус {Number} уехал");
    }
    void DriveBack()
    {
    Console.WriteLine($"автобус {Number}приехал");
    }

	public override Move()
	{
	Console.WriteLine($"автобус {Number} едет");
	}
}