using MyClasses.Transport;
using MyClasses.Cars;
using Incapsulation;
using Counters;
using Time;

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

            // Transport transport = new Transport("top");
            // System.Console.WriteLine(transport.Name);
            // transport.Moving();

            // Car car = new Car("por");
            // System.Console.WriteLine(car.Name);
            // car.Moving();

            // Transport transcar = new Car("frt");
            // System.Console.WriteLine(transcar.Name);
            // transcar.Moving();
            // Tiles tile=new Tiles("sd",0.45,0.6, 15);
            // System.Console.WriteLine(tile.GetData());
            // System.Console.WriteLine(tile.GetCountTiles(76));
            // System.Console.WriteLine($"заплати {tile.GetCountTiles(76)*tile.Price} рублей");

            // Children child1 = new Children();
            // child1.SetName("дима");
            // child1.SetSurName("Пупкин");
            // child1.SetAge(12);
            // System.Console.WriteLine(child1.GetName());
            // System.Console.WriteLine(child1.GetSurName());
            // System.Console.WriteLine(child1.GetAge());

            // Matrix mat1 = new Matrix(4, 2);
            // mat1.SetData();
            // System.Console.WriteLine();
            // mat1.ChangeData();

            // Counter cn = new Counter(99);
            // cn.Incriment();
            // Console.WriteLine(cn);
            // cn.Incriment();
            // Console.WriteLine(cn);
            // cn.Incriment();
            // Console.WriteLine(cn);

            SetTime time = new SetTime();
            time.Hours=5;
            time.ChangeH(time.Hours);
            // time.GetMinutes();
            // time.GetSeconds();
            time.ToPrint();
           






        }
    }
}