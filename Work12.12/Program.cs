

using OOPday1.MyClasses;

namespace OOPday1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            // CustomArray arrayObj = new CustomArray(5);
            // arrayObj.InicializationArray();
            // arrayObj.Print();
            // arrayObj.AddItem(random.Next(-100, 100), random.Next(-5, 5));
            // arrayObj.Print();
            // arrayObj.AddItem(random.Next(-100, 100));
            // arrayObj.Print();
            // arrayObj.AddItem(random.Next(-100, 100), random.Next(-100, 100), random.Next(-100, 100));
            // arrayObj.Print();
            // System.Console.WriteLine(arrayObj.Length);
            // System.Console.WriteLine(arrayObj.GetItem(random.Next(-5, arrayObj.Length)));
            // System.Console.WriteLine(arrayObj.SummMass());
            // System.Console.WriteLine(arrayObj.DiffMass());
            // CustomArray.Information();
            DateRange dateRange = new DateRange(DateTime.Now.AddDays(-5), DateTime.Now.AddDays(5));
            System.Console.WriteLine(dateRange);
            DateRange dateRange1 = new DateRange(dateRange);
            dateRange1.StartDate = DateTime.Now;
            System.Console.WriteLine(dateRange);
            System.Console.WriteLine(dateRange1);
            // дописать метод сумма и метод разность массива
        }
    }
}