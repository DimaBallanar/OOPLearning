using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишите программу, которая находит сумму всех элементов массива целых чисел.

namespace work1412.MyClasses
{
    public static class Zada4aStasa
    {

        public static double Average( this int[] mas, int indexStart, int indexEnd)
        {
            int temp = 0;
            int count = 0;
            for (int i = indexStart; i <= indexEnd; i++)
            {
                temp = mas[i]; count++;
            }
            return temp / count;

        }
    }
}
