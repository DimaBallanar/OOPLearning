namespace MyInterface;

public class TransportSystemCity
{
    private Transport[] Transports;
    private int CountPlane;
    private int CountBus;
    private int CountShip;

    public TransportSystemCity()
    {
        Transports = new Transport[33];
    }

    public void SetInAirport(Plane plane)
    {
        if (CountPlane == 11) throw new Exception("нет места в массиве");
        for (int i = 0; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                plane.Posadka();
                Transports[i] = plane;
                CountPlane++;
                return;
            }
        }
    }

    public void SetInBusStation(Bus bus)
    {
        if (CountBus == 11) throw new Exception("нет места в массиве");
        for (int i = 12; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                bus.Priehal();
                Transports[i] = bus;
                CountBus++;
                return;
            }
        }
    }

    public void SetInPort(Ship ship)
    {
        if (CountShip == 11) throw new Exception("нет места в массиве");
        for (int i = 23; i < Transports.Length; i++)
        {
            if (Transports[i] == null)
            {
                ship.Priplil();
                Transports[i] = ship;
                CountShip++;
                return;
            }
        }
    }


    public Plane GetFromAirport(int number)
    {
        for (int i = 0; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }
            if (transport is Plane plane && transport.NumberOfTransport == number)
            {
                Transports[i] = null;
                plane.Vzlet();
                CountPlane--;
                return plane;
            }
        }
        throw new Exception("нет самолета на базе");
    }

    public Bus GetFromBusStation(int number)
    {
        for (int i = 12; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }
            if (transport is Bus bus && transport.NumberOfTransport == number)
            {
                Transports[i] = null;
                bus.Poehal();
                CountBus--;
                return bus;
            }
        }
        throw new Exception("нет автобуса на базе");
    }

    public Ship GetFromPort(int number)
    {
        for (int i = 23; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }
            if (transport is Ship ship && transport.NumberOfTransport == number)
            {
                Transports[i] = null;
                ship.Poplil();
                CountShip--;
                return ship;
            }
        }
        throw new Exception("нет корабля в порту");
    }

    public (bool, string) BuyPlaneTicket(int number, int countSeats)
    {
        bool aprove = true;
        string result = "";
        int check = 0;
        for (int i = 0; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }

            if (transport.NumberOfTransport == number && transport is Plane plane)
            {
                check++;

                if (transport.CountSeats >= countSeats)
                {
                    aprove = true;
                    result = $"Вы купили {countSeats}";
                    transport.CountSeats = transport.CountSeats - countSeats;
                    return (aprove, result);
                }
                else
                {
                    aprove = false;
                    result = $"У транспорного средства осталось {transport.CountSeats} свободных мест";
                    
                }

                
            }

            continue;

        }
        if (check == 0) throw new Exception("нет самолета на базе");
        return (aprove, result);
    }

    public (bool, string) BuyBusTicket(int number, int countSeats)
    {
        bool aprove = true;
        string result = "";
        int check = 0;
        for (int i = 12; i < Transports.Length; i++)
        {

            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }

            if (transport.NumberOfTransport == number && transport is Bus bus)
            {
                check++;
                if (transport.CountSeats >= countSeats)
                {
                    aprove = true;
                    result = $"Вы купили {countSeats}";
                    transport.CountSeats = transport.CountSeats - countSeats;
                    return (aprove, result);
                }
                else
                {
                    aprove = false;
                    result = $"У транспорного средства осталось {transport.CountSeats} свободных мест";
                    return (aprove, result);
                }

                
            }

        }
        if (check == 0) throw new Exception("нет автобуса на базе");
        return (aprove, result);
    }


    public (bool, string) BuyShipTicket(int number, int countSeats)
    {
        bool aprove = true;
        string result = "";
        int check = 0;
        for (int i = 23; i < Transports.Length; i++)
        {
            var transport = Transports[i];
            if (transport == null)
            {
                continue;
            }

            if (transport.NumberOfTransport == number && transport is Ship ship)
            {
                check++;
                if (transport.CountSeats >= countSeats)
                {
                    aprove = true;
                    result = $"Вы купили {countSeats}";
                    transport.CountSeats = transport.CountSeats - countSeats;
                    return (aprove, result);
                }
                else
                {
                    aprove = false;
                    result = $"У транспорного средства осталось {transport.CountSeats} свободных мест";
                    return (aprove, result);
                }

                
            }

        }
        if (check == 0) throw new Exception("нет корабля в порту");
        return (aprove, result);
    }

}

