using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1302
{
    delegate void NextDay();
    public class Task1
    {
        public static int Num = 0;
        public void Main() { 
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
