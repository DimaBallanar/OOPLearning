using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, в которой с помощью делегатов и анонимных методов (лямбдавыражений) создается экземпляр делегата, который вызывается без аргументов, а
//результатом возвращает текстовое значение с названием дня недели ("Понедельник",
//"Вторник" и так до "Воскресенья"). При каждом новом вызове экземпляра результатом
//возвращается название следующего дня недели. После "Воскресенья" результатом
//возвращается "Понедельник" и так далее.


namespace Work1302
{
    delegate void NextDay();
    public class Task1
    {
        public static int Num = 0;
        public void Main()
        {
            NextDay azaza = delegate ()
                {
                    Console.WriteLine($"{Enum.GetName(typeof(WeekDay), Num++)}");
                    if (Num == 7)
                    {
                        Num = 0;
                    }
                };
            azaza();
        }
    }
}
