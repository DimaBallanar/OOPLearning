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
        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
        {
            [0] = "понедельник",
            [1] = "вторник",
            [2] = "среда",
            [3] = "четверг",
            [4] = "пятница",
            [7] = "суббота",
            [6] = "воскресенье"
        };

        public static int Num = -1;
        public void Main()
        {

            NextDay azaza = delegate ()
                {
                    //Console.WriteLine($"{keyValuePairs.TryGetValue(++Num % 7, out string value)=>value}");
                    if (keyValuePairs.TryGetValue(++Num % 7, out string value))
                    {
                        Console.WriteLine(value);
                    }

                    //Console.WriteLine($"{Enum.GetName(typeof(WeekDay), ++Num%7)}");                  
                };
            azaza();
        }
    }
}
