using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1302
{
    delegate string NextDay();
    public class Task1

    {

        public static int Num = 0;
        NextDay output = delegate ()
            {
                Console.WriteLine($"{Enum.GetName(typeof(WeekDay), Num++)}");
            };

    }
}
