using MyClasses.Transport;
using MyClasses.Cars;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Transport transport = new Transport(20, "car");
            // // transport.Moving();
            // // transport.Stoping();
            // Car bugatti = new Car("вася", 22);
            // // bugatti.Drift();
            // Car lambo = new Car("oprst");
            // // lambo.Stoping();
            // Transport[] Array = new Transport[3] { transport, bugatti, lambo };
            // foreach (Transport trans in Array)
            // {
            //     System.Console.WriteLine(trans.ToString());
            //     if(trans is Car car)
            //     {
            //         System.Console.WriteLine("This is car");
            //         car.Drift();

            //     }
            //     if(trans is Transport)
            //     {
            //         System.Console.WriteLine("This is transport");
            //     }

            //     trans.Moving();
            //     trans.Stoping();
            // }

            Transport transport = new Transport("top");
            System.Console.WriteLine(transport.Name);
            transport.Moving();

            Car car = new Car("por");
            System.Console.WriteLine(car.Name);
            car.Moving();

            Transport transcar = new Car("frt");
            System.Console.WriteLine(transcar.Name);
            transcar.Moving();

        }
    }
}