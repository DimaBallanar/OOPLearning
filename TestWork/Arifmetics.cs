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
            while (true)
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

        //        11. Напишите программу, которая находит все простые числа от 2 до N, где N - число,
        //введенное пользователем.

        public string FindProst()
        {
            Console.Write("ВВедите число от 2 до бесконечности: ");
            int.TryParse(Console.ReadLine(), out int number);
            string result = "";
            for (int i = 2; i <= number; i++)
            {
                int counter = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    result += i + ",";
                }
            }
            return result;
        }

        //        12. Напишите программу, которая находит наибольшую возрастающую
        //последовательность в массиве целых чисел.

        public string Posled(int[] massiv)  // доделать
        {
            string result = "";
            string temp = "";
            for (int i = 1; i < massiv.Length; i++)
            {
                if (massiv[i] > massiv[i - 1])
                {
                    temp += massiv[i - 1] + ",";
                }
                else if (massiv[i] <= massiv[--i])
                {
                    result += temp + " ";
                    temp = "";
                }
            }
            string[] charge = result.Split(" ");
            string finish = "";
            for (int i = 0; i < charge.Length - 1; i++)
            {
                if (charge.Length == 1)
                {
                    finish = charge[i];
                    continue;
                }
                else if (charge[i].Length > charge[i + 1].Length)
                {
                    finish = charge[i];
                }

            }

            return finish;
        }

        //        13. Напишите программу, которая реализует алгоритм сортировки слиянием для
        //массива целых чисел.



//        14. Напишите программу, которая находит наименьшее количество монет,
//необходимых для выдачи сдачи пользователю при покупке товара.У вас есть
//монеты номиналом 1, 5, 10, 25 и 50 центов.

//        15. Напишите программу, которая реализует алгоритм поиска в ширину для графа,
//представленного в виде списка смежности.


//        16. Напишите программу, которая реализует алгоритм быстрой сортировки для
//массива целых чисел.

    }
}
