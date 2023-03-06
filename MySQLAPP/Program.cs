

using MySQLAPP.DAOs;
using MySQLAPP.Models;

namespace MySQLAPP // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalsDAO query = new AnimalsDAO();
            //Animals animal = new Animals() { Name = "орел", Type = "птица" };
            //Console.WriteLine(query.Add(animal));
            //List<Animals> list = new List<Animals>
            //{
            //    new Animals() { Name = "воробей", Type = "bird" },
            //    new Animals() { Name = "синица", Type = "bird" },
            //    new Animals() { Name = "латсочка", Type = "bird" },
            //    new Animals() { Name = "хомочек", Type = "млекопетающие" },
            //    new Animals() { Name = "дятел", Type = "bird" }
            //};
            //query.AddRange(list);

            //Console.ReadKey();            
            //foreach (var item in query.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(query.GetAnimal(66));
            //string text = "млекопитающее";
            //foreach (var item in query.GetAnimal(text))
            //{
            //    Console.WriteLine(item);
            //}
            //query.DeleteAnimal(2);
           Console.WriteLine(query.GetAnimal(3));

        }
    }
}