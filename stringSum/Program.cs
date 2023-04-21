using System;
using stringSum;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringC str= new StringC();
            //string ops = str.InnerArray();
            //foreach (var op in ops) 
            //{
            //    Console.Write(op);
            //}
            //Console.WriteLine();
            //str.MakeLeftSide();
            //str.MakeRightSides();
            Code coe=new Code();
            coe.Array();
            //foreach(string x in coe.Array()) { Console.WriteLine(x); }
            Console.WriteLine(coe.Array()[1]);
        }
    }
}