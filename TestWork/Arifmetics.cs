using System;
using System.Collections.Generic;
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
            if(resultX%2==0)
            {
                return true;
            }
            return false;
        }
    }
}
