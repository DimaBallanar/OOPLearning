using MyInterface;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportSystemCity transportsystem=new TransportSystemCity();
            transportsystem.SetInAirport(new Plane("airbus1", 776));
            transportsystem.SetInAirport(new Plane("airbus1", 777));
        }
    }
}
























