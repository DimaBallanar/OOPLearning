using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class Arifmetics
    {
        //        Напишите программу, которая вычисляет сумму двух чисел, введенных
        //пользователем.
        public double Sum(string x, string y)
        {
            if (double.TryParse(x, out double resultX) && double.TryParse(y, out double resultY))
            {
                return resultX + resultY;
            }
            return 0;
        }
        //        Напишите программу, которая определяет, является ли введенное число четным
        //или нечетным
        public bool Chetnoe(string x)
        {
            double.TryParse(x, out double resultX);
            if (resultX % 2 == 0)
            {
                return true;
            }
            return false;
        }
        //        Напишите программу, которая находит среднее арифметическое двух чисел,
        //введенных пользователем.

        public double SrAr(string x, string y)
        {
            double.TryParse(x, out double resultX);
            double.TryParse(y, out double resultY);
            return (resultX + resultY) / 2;
        }

        //        4. Напишите программу, которая запрашивает у пользователя длину и ширину
        //прямоугольника, а затем выводит его площадь.

        public double Square()
        {
            Console.Write("Введите длину прямоугольника: ");
            double.TryParse(Console.ReadLine(), out double resultX);
            Console.Write("Введите ширину прямоугольника: ");
            double.TryParse(Console.ReadLine(), out double resultY);
            Console.Write("Площадь прямоугольника равна ");
            return resultX * resultY;
        }

        //        Напишите программу, которая проверяет, является ли введенная строка
        //палиндромом(слово или фраза, которые читаются одинаково слева направо и
        //справа налево).

        public string Palindrom()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            //string[] temp = text.ToCharArray();
            if (text.ToLower() == string.Join("", text.Split("").Reverse()).ToLower())
            {
                return $"{text} - палиндром";
            }
            return $"{text} - не палиндром";
        }

        //        Напишите программу, которая запрашивает у пользователя три числа и выводит
        //на экран наименьшее из них.

        public string Max()
        {
            Console.Write("введите число а: ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("введите число b: ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.Write("введите число c: ");
            double.TryParse(Console.ReadLine(), out double c);
            if (Math.Max(a, b) > c)
            {
                return $"{Math.Max(a, b)}";
            }
            return $"{c}";
        }

        //        7. Напишите программу, которая запрашивает у пользователя строку и выводит на
        //экран количество гласных букв в этой строке.
        public int NumGlas()
        {
            Console.Write("ВВедите текст: ");
            string text=Console.ReadLine();
            string glasnie = "аиеёоуыэюяАИЕЁОУЫЭЮЯ";
            int num = 0;
            foreach(char c in text)
            {
                if(glasnie.Contains(c))
                {
                    num++;
                }
            }
            return num;
        }


    }
}
