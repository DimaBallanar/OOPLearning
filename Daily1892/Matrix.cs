using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily1892
{
    public class Matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int[,] Block { get; private set; }
        public Matrix(int stroka, int column)
        {
            Rows = stroka;
            Columns = column;
            Block = new int[Rows, Columns];
        }
        public void Zapolnenie()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Block[i, j] = rnd.Next(0, 100);
                }
            }
            Print();
        }

        public void Reverse()
        {
            int[,] ints = new int[Columns, Rows];
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    ints[i, j] = Block[j, i];
                }
            }
            Block = ints;
            (Rows, Columns) = (Columns, Rows);   // кортеж,перезапись пременных
            Print();
        }

        private void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{Block[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
