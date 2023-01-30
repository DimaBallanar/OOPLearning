namespace MyInterface;

public class TransportSystemCity
{
    private Transport[] Transports;
    private int CountShip;
    private int CountBus;
    private int CountPlane;

    public TransportSystemCity()
    {
        Transports = new Transport[33];
    }

    public void SetInAirport(Plane plane)
    {
        if (CountPlane == 11) throw new Exception("нет места в массиве для самолёта");

        for (int i = 0; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                plane.SitGround();
                Transports[i] = plane;
                CountPlane++;
                
            }
        }
    }
    /*
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
        for (int i = 0; i < Transport.Length; i++)
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
        for (int i = 0; i < Transport.Length; i++)
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
                
            }
        }
    }
    */
}