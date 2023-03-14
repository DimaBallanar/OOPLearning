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
    }
}
