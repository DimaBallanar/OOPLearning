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
                return;
            }
        }
    }

    public void SetInBusStation(Bus bus)
    {
        if (CountBus == 11) throw new Exception("нет места в массиве для автобуса");
        for (int i = 0; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                bus.DriveBack();
                Transports[i] = bus;
                CountBus++;
                return;
            }
        }
    }

    public void SetInPort(Ship ship)
    {
        if (CountShip == 11) throw new Exception("нет места в массиве для корабля");
        for (int i = 0; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                ship.SwimHere();
                Transports[i] = ship;
                CountShip++;
                return;
            }
        }
    }

    public Plane GetFromAirPort(int number)
    {
        for (int i = 0; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null) continue;
            if (transport is Plane plane && transport.Number == number)
            {
                Transports[i] = null;
                plane.FlyAway();
                CountPlane--;
                return plane;
            }
        }
        throw new Exception("нет элемента в массиве");

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