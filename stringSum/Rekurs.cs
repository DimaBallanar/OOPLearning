using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSum
{
    public class Rekurs
    {
        public static string Text = "123+1*22";

        public static char[] Pattern = new[] { '-', '+', '*', '/' };
        public static char Minus = '-';
        public static char Plus = '+';
        public static char Ymnog = '*';
        public static char Deli = '/';

        static List<string> Checker;
        static void RekursString(string text)
        {
            if (text.Contains(Minus) || text.Contains(Plus)) { Checker.Add(text); }
            
           
        }
    }
}
