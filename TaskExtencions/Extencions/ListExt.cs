using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskExtencions.Extencions
{
    public static class ListExt
    {
        public static int ListExtencion(this List<int> num)
        {
            int count = 0;
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    count += i;
                }
            }
            return count;

        }
    }
}
