using System;
using Myclasses.Employee;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВедите Имя работника: ");
            string? name=Convert.ToString(Console.ReadLine());
            Console.Write("ВВедите личный номер : ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.Write("В какую смену работает?дневная/вечерняя");
            string? smena=Convert.ToString(Console.ReadLine());
            ProductionWorker worker=new ProductionWorker(name,number,smena,money);
        }
    }
}