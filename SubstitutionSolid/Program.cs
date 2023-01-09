using System;
using Myclasses.Employee;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("ВВедите Имя работника: ");
            // string? name = Convert.ToString(Console.ReadLine());
            // Console.Write("ВВедите личный номер : ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // Console.Write("В какую смену работает?дневная/вечерняя:  ");
            // string? smena = Convert.ToString(Console.ReadLine());
            // System.Console.Write("какая ставка оплаты труда в час?: ");
            // double check = Convert.ToDouble(Console.ReadLine());
            ProductionWorker worker = new ProductionWorker();
            {
                worker.Name = worker.Im9();
                worker.Number = worker.Num();
                worker.WorkPeriod = worker.Period();
            }
            worker.Print();
            // System.Console.Write("какой оклад у начальника смены? :");
            // double oklad=Convert.ToDouble(Console.ReadLine());
            // System.Console.Write("годовая премия");
            // double premiya=Convert.ToDouble(Console.ReadLine());
            // ShiftSupervisor boss=new ShiftSupervisor(name,number,oklad,premiya);



        }
    }
}