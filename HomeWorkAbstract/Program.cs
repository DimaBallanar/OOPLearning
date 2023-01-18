using System;
using Myclasses;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data tro = new Data();
            System.Console.WriteLine(tro.IsValidEmail("D.Ballanar@gmail.com"));
            System.Console.WriteLine(tro.IsValidPwd("1234123", "1234123"));
            System.Console.WriteLine(tro.IsValidId("144"));
            Server check=new Server(12,"Dima","Balla","123WEsd");
            check.GetUser();

        }
    }
}