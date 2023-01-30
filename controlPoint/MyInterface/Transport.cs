namespace MyInterface;

public abstract class Transport
{
	public string Name{get;set;}
	public int Number{get;set;}

	public Transport(string name, int number)
	{
	Name=name;
	Number=number;
	}
	public abstract void Move(); 
}