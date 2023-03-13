

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using work1412.MyClasses;

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

            //Reader[] readers = new Reader[5];
            //for (int i = 0; i < readers.Length; i++)
            //{
            //    readers[i] = new Reader() { Name = $"Reader {i + 1}" };
            //    Random rnd = new Random();
            //    readers[i].TakeBook(rnd.Next(1, 10));
            //    readers[i].ReturnBook(rnd.Next(1, 10));
            //}
            //Напишите программу, которая находит сумму всех элементов массива целых чисел.

            //Random random = new Random();
            //List<int> list = new List<int>();
            //for (int i = 0; i < 30; i++)
            //{
            //    list.Add(random.Next(0, 100));
            //}

            //foreach (int s in list)
            //{
            //    sum += s;
            //}
            //Console.WriteLine(sum);

            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    for (int j = i + 1; j < list.Count; j++)
            //    {
            //        if (list[i] > list[j])
            //        {
            //            (list[i], list[j]) = (list[j], list[i]);                       
            //        }
            //    }
            //}
            //try
            //{
            //    Console.WriteLine(string.Join(",", list));
            //    Console.WriteLine(list[0]);
            //    Console.WriteLine(list[list.Count - 1]);
            //}
            //catch (Exception e) { Console.WriteLine("пустота"); }

            //string userInput = Convert.ToString(Console.ReadLine());
            //int temp=userInput.Length-1;
            //bool t = true;
            //for(int i=0;i<userInput.Length/2;i++)
            //{
            //    if (userInput[i] != userInput[userInput.Length-1-i])
            //    {
            //        t = false;
            //        break;
            //    }                
            //}
            //if(t)
            //{
            //    Console.WriteLine("палиндром");
            //}


            //Напишите метод для нахождения наименьшего общего кратного двух чисел.
            // Пользователь должен вводить два числа, а программа должна выводить на экран их наименьшее общее кратное.

            //Console.Write("введите число а : ");
            //string texta = Console.ReadLine();                   
            //Console.Write("введите число b : ");
            //string textb = Console.ReadLine();
            ////int.TryParse(Console.ReadLine(), out int valueb);                
            //if (int.TryParse(texta, out int valuea) && int.TryParse(textb, out int valueb))
            //{
            //    Console.WriteLine(ProstieDeliteli(valuea, valueb));
            //}
            //else
            //{
            //    Console.WriteLine("ввели не тот формат");
            //}
            //static int ProstieDeliteli(int a, int b)
            //{
            //    (int minValue, int maxValue) = a > b ? (b, a) : (a, b);

            //    for (int i = 1; i < minValue / 2; i++)
            //    {
            //        if (maxValue * i % minValue == 0)
            //        {
            //            return maxValue * i;
            //        }
            //    }
            //    return maxValue * minValue;
            //}
            //************************************************************************************************
            //Создайте приложение для нахождения суммы всех чисел от 1 до 1000, кратных 3 или 5.

            //Console.WriteLine(Sum());

            //static int Sum()
            //{
            //    int pot = 0;

            //        for(int i=3;i<1001;i++)
            //        {
            //            if(i%3==0&&i%5==0) 
            //            { 
            //                pot += i; 
            //            }
            //        }                
            //    return pot;
            //}

            //Создайте метод расширения для определения среднего значения интервала массива /
            //коллекции чисел.Пользователь должен вводить индексы начала и конца интервала для подсчёта среднего значения. 


            //Console.Write("ВВедите длину  массива: ");
            //int value=Convert.ToInt32(Console.ReadLine());
            //int[] massiv = new int[value];
            //Random rnd=new Random();
            //for(int i=0;i<massiv.Length;i++) { massiv[i]= rnd.Next(1,100); }
            //int a=Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(massiv.Average(a,b));

            //Напишите программу, которая запрашивает у пользователя число и затем проверяет,
            //    является ли оно палиндромом(то есть числом, которое читается одинаково как справа налево, так и слева направо).
            //string num = Console.ReadLine().Trim();
            //string ttr = string.Join("", num.Reverse());
            //if(num==ttr) { Console.WriteLine($"{num} - число палиндром"); }
            //if (int.TryParse(num, out int T))
            //{
            //    string numR = "";
            //    for (int i = num.Length - 1; i >= 0; i--)
            //    {
            //        numR += num[i];
            //    }
            //    if (num == numR)
            //    {
            //        Console.WriteLine($"{num} - число палиндром");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num} - число не палиндром");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("вы ввели не число");
            //}




            //Напишите функцию, которая принимает на вход два массива целых чисел и возвращает новый массив,
            //    содержащий элементы обоих массивов без повторений.

            int[] mass1 = { 1, 2, 3, 4, 5 };
            int[] mass2 = { 1, 4, 5, 11, 14 };

            static int[] Massa(int[] mass, int[] mass2)
            {
                int[] result = mass.Concat(mass2).ToArray();
                string tett = "";
                for(int i=0;i<result.Length;i++)
                {
                    tett += result[i];
                    for(int j=++i;j<result.Length-1;j++)
                    {
                        if (result[i] == result[j])
                        {
                            result[j] = 0;
                        }
                    }
                }
                
            }
            Console.WriteLine(String.Join(",", Massa(mass1, mass2)));
        }
    }
}