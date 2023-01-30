namespace MyInterface;

public class TransportSystemCity
{
    public Transport[] Transport;
    // public Transport[] Ts=new Transport[];

    public TransportSystemCity()
    {
        Transport = new Transport[33];

    }

    public void SetInAirport(Plane plane)
    {
        int count = 0;
        for (int i = 0; i < Transport.Length; i++)
        {
            if (Transport.Name == "Plane")
            {
                count++;
            }
        }
        if (count >= 11) throw new Exception("нет места в массиве");

        // base.SitGround();
        Transport.SitGround();
        
    }

    public void SetInBusStation(Bus bus)
    {
        int count = 0;
        for (int i = 0; i < Transport.Length; i++)
        {
            if (Transport.Name == "автобус")
            {
                count++;
            }
        }
        if (count >= 11) throw new Exception("нет места в массиве");

        base.DriveBack();
    }

    public void SetInPort(Ship ship)
    {
        int count = 0;
        for (int i = 0; i < Transport.Length; i++)
        {
            if (Transport.Name == "корабль")
            {
                count++;
            }
        }
        if (count >= 11) throw new Exception("нет места в массиве");

        base.SwimHere();
    }

    public Plane GetFromAirPort(int number)
    {
        for (int i=0; i < Transport.Length; i++)
        {
            if (Transport.Name == "Plane" && Transport.Number == number)
            {
                Transport[i] = default;
                return base.FlyAway();
            }
            else
            {
                throw new Exception("нет элемента в массиве");
                
            }
        }
    }
    public Bus GetFromBusStation(int number)
    {
        for (int i=0; i < Transport.Length; i++)
        {
            if (Transport.Name == "автобус" && Transport.Number == number)
            {
                Transport[i] = default;
                return base.DriveAway();
            }
            else
            {
                throw new Exception("нет элемента в массиве");
              
            }
        }
    }

    public Ship GetFromPort(int number)
    {
        for (int i; i < Transport.Length; i++)
        {
            if (Transport.Name == "корабль" && Transport.Number == number)
            {
                Transport[i] = default;
                return base.SwimAway();
            }
            else
            {
                throw new Exception("нет элемента в массиве");
                return null;
            }
        }
    }
}