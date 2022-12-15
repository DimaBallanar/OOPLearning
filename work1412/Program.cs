

namespace OOPTask2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            phone2.Number = "+375255218579";
            phone2.Model = "Iphone";
            phone2.Weigth = "1кг";
            Phone phone3 = new Phone()
            {
                Number = "+375255435579",
                Model = "Honor",
                Weigth = "4кг"
            };
            System.Console.WriteLine(phone1);
            System.Console.WriteLine(phone2);
            System.Console.WriteLine(phone3);

        }
    }
}