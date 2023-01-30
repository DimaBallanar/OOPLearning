using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Написать метод раширения, который преобразует тип string в тип int с проверкой строки на 
//наличие только чисел

namespace TaskExtencions.Extencions
{
    public static class StringExtencion
    {
        
        public static int ToInt(this string str)
        {
            string result = "";
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }

            }
            return string.IsNullOrEmpty(result) ? 0 : int.Parse(result);

        }
    }
}
