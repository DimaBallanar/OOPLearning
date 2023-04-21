using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace stringSum
{
    public class StringC
    {
        //                              1 2  3   4 5    6   7     8     9  10  11    12 13
        public static string Text = "123+1*22-17 /2+  22- 19+33.2 * 124 -11+ 22- 14.9 *2  -1";

        public static string Pattern = "*/+-";
        public char CentralSymbol;
        public string InnerArray()
        {
            string resultArray = Text.Replace(" ", "");//.Split("");    // чистим все пробелы и массив забиваем
            return resultArray;
        }
        public void MakeRightSides()
        {
            string textAll = InnerArray();
            string text = MakeLeftSide();
            string RigthPart = "";

            for (int i = text.Length+1; i < textAll.Length; i++)
            {
                RigthPart += textAll[i];

            }
            Console.WriteLine($"{RigthPart}    это правая часть");
        }
        public int FindMiddleIndex(string text) // считаем арифметические символы и ищем средний
        {
            int counter = 0;
            foreach (char c in text)
            {
                if (Pattern.Contains(c))
                {
                    counter++;
                }
            }
            return counter / 2;
        }

        public string MakeLeftSide()
        {
            string text = InnerArray();
            string LeftPart = "";
            int counter = FindMiddleIndex(text);

            foreach (char c in text)
            {
                if (counter >= 0)
                {
                    if (Pattern.Contains(c))
                    {
                        LeftPart += c;
                        counter--;
                    }
                    else
                    {
                        LeftPart += c;
                    }
                }
                //else
                //{
                //    Console.WriteLine($"{LeftPart}   это левая часть");
                //    return LeftPart;
                //}
            }
            CentralSymbol = LeftPart[LeftPart.Length - 1];
            LeftPart = LeftPart.Remove(LeftPart.Length - 1);
            Console.WriteLine($"{LeftPart}   это левая часть");
            return LeftPart;
        }
        // надо дернуть последний арифметический знак с левой части              *****DONE   CentralSymbol
        
        // нужна логика дробления по элементам куска стрингов
        public void Droubl(string text)  
        {
            string nabor= "123 + 1 * 22 - 17 / 2 + 22 - 19";

        }







    }
}
