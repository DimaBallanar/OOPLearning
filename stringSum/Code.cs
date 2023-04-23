using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace stringSum
{
    public class Code
    {
        //public static string Text = "123+1*22-17 /2+  22- 19+33.2 * 124 -11+ 22- 14.9 *2  -1";
        public static string Text = "123+1*22-17"; //public static string Text = "123+1*22-17 /2+  22- 19+33.2 * 124 -11+ 22- 14.9 *2  -1";
        public static string Min = "-";
        public static string Pl = "+";
        public static string Ym = "*";
        public static string Del = "/";
        public static string Pattern = "*/+-";

        public List<string> Array(string text)
        {
            //string text = Text;
            text = text.Replace(" ", "");
            text = text.Replace('.', ',');
            string element = "";
            List<string> list = new List<string>();
            
            for (int i = 0; i < text.Length; i++)
            {
                if (!Pattern.Contains(text[i]))
                {
                    element += text[i];
                }
                else if (Pattern.Contains(text[i]))
                {
                    list.Add(element);
                    list.Add(text[i].ToString());
                    element = "";
                }              
            }
            return list;
        }

        //public string[] ListStringConvertor(List<string> list)
        //{
        //    string[] strings=new string[list.Count];

        //}
        public List<string> RestIn()
        {
            List<string> text = Array();
            List<string> res = new List<string>();
            for(int i=1;i<text.Count-1;)
            {
                if (text[i]==Ym) { res.Add((Ymnojenie(Convert.ToDouble(text[i - 1]), Convert.ToDouble(text[i + 1]))).ToString()); }
                if (text[i] == Del) { res.Add((Delenie(Convert.ToDouble(text[i - 1]), Convert.ToDouble(text[i + 1]))).ToString()); }
                else { res.Add(text[i - 1]); res.Add(text[i]); }
                i = i + 2;
            }
            return res;
        }
        public double ConsoleReturn()
        {         //4-6-8-9-11
            List<string> text = RestIn();
            double result = Convert.ToDouble(text[0]);
            for (int i = 1; i < text.Count - 1;)
            {
                if (text[i] == Pl) { result += Convert.ToDouble(text[i + 1]); }
                if (text[i] == Min) { result -=Convert.ToDouble(text[i + 1]); }               
                i = i + 2;
            }
            return result;
        }
        //public double Minus(double value, double value1)
        //{
        //    return value - value1;
        //}
        //public double Plus(double value, double value1)
        //{
        //    return value + value1;
        //}
        public double Ymnojenie(double value, double value1)
        {
            return value * value1;
        }
        public double Delenie(double value, double value1)
        {
            return value / value1;
        }
    }
}
