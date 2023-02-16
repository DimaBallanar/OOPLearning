using System;
using System.Security.Cryptography.X509Certificates;
using Work1302;
using static Work1302.Extension;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //delegate int CalculateValues(int number1, int number2, int number3);
        //static void Main(string[] args)
        //{
        //    CalculateValues method = new InnerProgram1().Sum;
        //    Console.WriteLine(method(5, 2, 4));
        //    InnerProgram1 program1 = new InnerProgram1();
        //    method = program1.Multiplication;
        //    Console.WriteLine(method(5, 2, 4));
        //    Class1 class1= new Class1();
        //    method = class1.CustomCalculate;
        //    Console.WriteLine(method(5, 2, 4));


        //}
        //public class InnerProgram1
        //{
        //    public int Sum(int number1, int number2, int number3) { return number1 + number2 + number3; }

        //    public  int Multiplication(int number1, int number2, int number3) { return number1 * number2 * number3; }
        //}

        //public delegate void CalculateValues(double number);
        //delegate void UserDecorator(ref User user);
        //public delegate bool Filter<T>(T propertyT);

        private static void Main(string[] args)
        {

            //Extension exe = new Extension();

            //CalculateValues method = delegate (double value)
            //{
            //    Console.WriteLine((value + value) / 3);
            //};
            //method(5);
            //method = (double values) => { Console.WriteLine((values + values) / 3); };
            //method(5);
            //Test(method);


            //CalculateValues method = Mult2;
            //method += Sqr;
            //method(5);
            //method += Sqr;
            //method(5);
            //Console.WriteLine("-------------------------");
            //method -= null;
            //method(5);
            //Console.WriteLine("-------------------------");
            //method -= Mult3;
            //method(5);
            //User user = null;

            //UserDecorator decorator = AddAge;
            //decorator += AddId;
            ////decorator += AddAge;
            //decorator += AddName;
            //decorator(ref user);
            //Console.WriteLine(user);



            //public static void Test(CalculateValues test)
            //{
            //    Console.WriteLine("введите число");
            //    double x=Convert.ToDouble(Console.ReadLine());
            //    test(x);
            //}
            //public static void CreateUser(ref User user)
            //{
            //    user = new User();
            //}
            //public static void AddId(ref User user)
            //{
            //    if (user == null) { CreateUser(ref user); }
            //    user.Id = 4;
            //}
            //public static void AddName(ref User user)
            //{
            //    if (user == null) { CreateUser(ref user); }
            //    user.Name = "Tom";
            //}
            //public static void AddAge(ref User user)
            //{
            //    if (user == null) { CreateUser(ref user); }
            //    user.Age = 1;
            //}

            //public static void Mult2(double x)
            //{
            //    Console.WriteLine($"Mult2 {x * 2}");
            //}
            //public static void Mult3(double x)
            //{
            //    Console.WriteLine($"Mult3 {x * 3}");
            //}
            //public static void Sqr(double x)
            //{
            //    Console.WriteLine($"Sqr {x * x}");
            //}
            //List<int> lsit = new List<int>();
            //lsit.Add(1);
            //lsit.Add(2);
            //lsit.Add(3);
            //lsit.Add(4);
            //lsit.Add(5);
            //lsit.Add(6);
            //lsit.Add(7);
            //Filter<int> method = delegate (int value)
            //    {
            //        return value % 2 == 0;
            //    };
            //List<int> newlist = lsit.FilterList(method);
            ////Console.ReadKey();
            //List<User> list = new List<User>();
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    User user = new User();
            //    user.Id = i + 1;
            //    user.Name = $"{user.Id} + Name";
            //    user.Age = rnd.Next(10, 25);
            //    list.Add(user);
            //}
            //Filter<User> filt = (User user) => user.Id % 3 == 0;
            //List<User> newlist2 = list.FilterList(filt);
            //foreach (var item in newlist2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //Task1 part = new Task1();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //part.Main();
            //Task2 part2 = new Task2();
            //part2.Main(2, 3, 4);
            
            string text = "This will check over each node in the data and see if the rowIndex is 0, when it is, it uses the node object to set the selected attribute";




        }
    }
}