﻿

using MySQLAPP.DAOs;
using MySQLAPP.Models;

namespace MySQLAPP // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalsDAO query = new AnimalsDAO();
            //query.GetAll();
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
            //Console.WriteLine(query.GetAnimal("птица"));


            //CarsDao query= new CarsDao();
            //List<Car> cars = new List<Car>
            //{
            //    new Car() {  Name = "Zaporogec", Color = "#112233", TimeCreate = DateTime.Now, Type = "bus", Mileage = 11 },
            //    new Car() {  Name = "lada", Color = "#112233", TimeCreate = DateTime.Now, Type = "bus", Mileage = 11 },
            //    new Car() {  Name = "suzuki", Color = "#112233", TimeCreate = DateTime.Now, Type = "bus", Mileage = 11 }
            //};
            //query.AddFew(cars);
            //Car car = new Car() { Code=4, Name = "VW", Color = "#112233", TimeCreate = DateTime.Now, Type = "bus", Mileage = 11 };
            //Car car = new Car() { Code = 4, Name = "VW", Color = "#112233", Type = "bus", Mileage = 11.00 };
            //Console.WriteLine(query.Add(car));
            //foreach (var item in query.GetCars())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(query.GetCar(2));



            UserDAO quer = new UserDAO();
            //User user = new User() { Name="Антонио", Password="вфв312йй", Email="antonion@gmail.com",LastLogin= DateTime.Now,Money= 812.2 };
            //Console.WriteLine( quer.Add(user));
            //List<User> users = new List<User>
            //{
            //    new User(){ Name="Марк", Password="вфв312йй", Email="Mark@gmail.com",LastLogin= DateTime.Now,Money= 812.2 },
            //     new User(){ Name="Чили", Password="вфв312йй", Email="chili@gmail.com",LastLogin= DateTime.Now,Money= 812.2 },
            //      new User(){ Name="Паприка", Password="вфв312йй", Email="paprika@gmail.com",LastLogin= DateTime.Now,Money= 812.2 }
            //};
            //quer.AddFew(users);            
            //foreach (var item in quer.GetUsers())
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(quer.GetUser(3));

        }
    }
}