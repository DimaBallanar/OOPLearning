﻿using System;
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
            string text = Console.ReadLine();
            string glasnie = "аиеёоуыэюяАИЕЁОУЫЭЮЯ";
            int num = 0;
            foreach (char c in text)
            {
                if (glasnie.Contains(c))
                {
                    num++;
                }
            }
            return num;
        }

        //        8. Напишите программу, которая запрашивает у пользователя год рождения и
        //выводит его возраст на текущую дату.
        public int Age()
        {
            Console.Write("Введите год своего рождения: ");
            int.TryParse(Console.ReadLine(), out int x);
            return DateTime.Now.Year - x;
        }

        //        9. Напишите программу, которая запрашивает у пользователя два числа и находит
        //их наибольший общий делитель

        public int NOD()
        {
            Console.Write("введите число а: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("введите число b: ");
            int.TryParse(Console.ReadLine(), out int b);
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        //        10. Напишите программу, которая генерирует случайное число от 1 до 100 и
        //предлагает пользователю угадать это число, давая подсказки(больше/меньше),
        //если введенное число не совпадает с загаданным.

        public void FindNumber()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            Console.WriteLine(x);
            while(true)
            {
                Console.Write("введите загаданное число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == x)
                {
                    Console.WriteLine("вы угадали!");
                    break;
                }
                else if (number > x)
                {
                    Console.WriteLine("загаданное число меньше");
                }
                else
                {
                    Console.WriteLine("загаданное число больше");
                }
            }
        }
    }
}