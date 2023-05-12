using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal static class StringExtension
    {
        public static string DecorateSymbol(this string str, char symbol)
        {
            StringBuilder builder= new StringBuilder();
            foreach(var ch in str)
            {
                builder.Append(ch);
                if(char.IsDigit(ch))
                {
                    builder.Append(symbol);
                }
            }
            return builder.ToString();
        }
    }
}
