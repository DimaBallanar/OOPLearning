using System;
using Myclasses.Employee;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductionWorker worker = new ProductionWorker();

            worker.Name = worker.Im9();
            worker.Number = worker.Num();
            worker.WorkPeriod = worker.Period();
            worker.MoneyPerHour = worker.CashMoney();
            worker.Print();

            ShiftSupervisor boss = new ShiftSupervisor();
            boss.Name = boss.Im9();
            boss.Number = boss.Num();
            boss.Oklad = boss.Okla();
            boss.Premiya = boss.Prem();



        }
    }
}