






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

	public override Move()
	{
	Console.WriteLine("Plane {Number} летит");
	}
}

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

	public override Move()
	{
	Console.WriteLine("корабль {Number} плывет");
	}
}


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
    Console.WriteLine("автобус {Number}приехал");
    }

	public override Move()
	{
	Console.WriteLine("автобус {Number} едет");
	}
}

namespace MyInterface;

public class TransportSystemCity
{
	public Transport[] Transport;

	public TransportSystemCity()
	{
      Transport=new Transport[33];

    	}

public void SetInAirport(Plane plane)
{
int count=0;
for(int i=0;i<Transport.Length;i++)
{
if(Transport.Name=="Plane")
{
	count++;
}
}
	if(count>=11) throw new OurException("нет места в массиве");

	base.SitDown();
}

public void SetInBusStation(Bus bus)
{
int count=0;
for(int i=0;i<Transport.Length;i++)
{
if(Transport.Name=="автобус")
{
	count++;
}
}
	if(count>=11) throw new OurException("нет места в массиве");

	base.DriveBack();
}

public void SetInPort(Ship ship)
{
int count=0;
for(int i=0;i<Transport.Length;i++)
{
if(Transport.Name=="корабль")
{
	count++;
}
}
	if(count>=11) throw new OurException("нет места в массиве");

	base.SwimHere();
}

public Plane GetFromAirPort(int number)
{
	for(int i;i<Transport.Length;i++)
	{
	if(Transport.Name=="Plane" && Transport.Number==number)
	{
	Transport[i]=default;
	return base.FlyAway();
	}
	else
	{
	throw new OurException("нет элемента в массиве");
	return null;
	}
	}
}
public Bus GetFromBusStation(int number)
{
	for(int i;i<Transport.Length;i++)
	{
	if(Transport.Name=="автобус" && Transport.Number==number)
	{
	Transport[i]=default;
	return base.DriveAway();
	}
	else
	{
	throw new OurException("нет элемента в массиве");
	return null;
	}
	}
}

public Ship GetFromPort(int number)
{
	for(int i;i<Transport.Length;i++)
	{
	if(Transport.Name=="корабль" && Transport.Number==number)
	{
	Transport[i]=default;
	return base.SwimAway();
	}
	else
	{
	throw new OurException("нет элемента в массиве");
	return null;
	}
	}
}






}




}




