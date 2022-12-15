

namespace OOPTask2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     Phone phone1 = new Phone(string.Empty, "", "");
            //     System.Console.WriteLine(phone1);
            //     phone1.RecieveCall("LoL");
            //     System.Console.WriteLine(phone1.GetNumber());
            //     System.Console.WriteLine();

            //     Phone phone2 = new Phone("+375255218579", "Iphone", "1kg");
            //     // phone2.Number = "+375255218579";
            //     // phone2.Model = "Iphone";
            //     // phone2.Weight = "1кг";
            //     System.Console.WriteLine(phone2);
            //     phone2.RecieveCall("Kek");
            //     System.Console.WriteLine(phone2.GetNumber());
            //     System.Console.WriteLine();

            //     Phone phone3 = new Phone(model: "Honor", weight: "4kg", number: "+2323221431")
            //     {
            //         // Number = "+375255435579",
            //         // Model = "Honor",
            //         // Weight = "4кг"
            //     };
            //    phone3.SendMessage("hello","123131141","322222");

            // Person person = new Person();
            // person.Move();
            // person.Talk();
            // Person person1 = new Person("дмитрий", 11);
            // person1.Move();
            // person1.Talk();

            // Matrix matrix=new Matrix(4,4);
            // matrix.InitMatrix();
            // matrix.Print();

            Reader[] readers = new Reader[5];
            for (int i = 0; i < readers.Length; i++)
            {
                readers[i] = new Reader() { Name = $"Reader {i + 1}" };
                Random rnd = new Random();
                readers[i].TakeBook(rnd.Next(1, 10));
                readers[i].ReturnBook(rnd.Next(1, 10));
            }



        }
    }
}