using MyInterface;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TransportSystemCity transportsystem=new TransportSystemCity();
            transportsystem.SetInAirport(new Plane("airbus1", 776,11));
            transportsystem.SetInAirport(new Plane("airbus1", 777,11));
            transportsystem.GetFromAirport(776);            
            Console.WriteLine(transportsystem.BuyPlaneTicket(779, 8));       
            Console.WriteLine(transportsystem.BuyPlaneTicket(777, 3));     
            Console.WriteLine(transportsystem.BuyPlaneTicket(777, 2));

        }
    }
}
























