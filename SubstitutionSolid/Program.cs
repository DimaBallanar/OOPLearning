using System;
using Myclasses.Employee;
using Myclasses.Person;
using Myclasses.Worker;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ProductionWorker worker = new ProductionWorker();

            // worker.Name = worker.Im9();
            // worker.Number = worker.Num();
            // worker.WorkPeriod = worker.Period();
            // worker.MoneyPerHour = worker.CashMoney();
            // worker.Print();

            // ShiftSupervisor boss = new ShiftSupervisor();
            // boss.Name = boss.Im9();
            // boss.Number = boss.Num();
            // boss.Oklad = boss.Okla();
            // boss.Premiya = boss.Prem();


            // Customer user = new Customer();
            // user.Name = user.GetName();
            // user.Adress = user.GetAdress();
            // user.TelNumber = user.GetNumber();
            // user.ClientId = user.GetId();
            // user.Sms = user.CheckCall();
            // user.Print();

            Singer akon=new Singer();
            akon.Name=akon.GetName();
            akon.Surname=akon.GetSurname();
            akon.Birth=akon.GetBirth();
            akon.Years=akon.GetYears();
            akon.Style=akon.GetStyle();
            akon.Print();


        }
    }
}