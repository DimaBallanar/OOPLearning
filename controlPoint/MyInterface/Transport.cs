namespace MyInterface;

public abstract class Transport
{
	public string Name{get;set;}
	public int NumberOfTransport{get;set;}

	public Transport(string name, int number)
	{
	Name=name;
	NumberOfTransport=number;
	}
	public abstract void Move(); 
}