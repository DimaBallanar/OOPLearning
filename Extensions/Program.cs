using System;
using Extensions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "12no31b2hgw1231";
            Console.WriteLine(text);
            string newText = text.DecorateSymbol('$');
            Console.WriteLine(newText);
        }
    }
}