using System;
using Server;
using ServerBy;
using ServerPo;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ServerGetAll server=new ServerGetAll();
            // server.Controller();
            // ServerByld serv=new ServerByld();
            // serv.Controller(3);
            System.Console.Write("Введите имя: ");
            string? name=Convert.ToString(Console.ReadLine());
            System.Console.Write("Введите возраст: ");
            int age=Convert.ToInt32(Console.ReadLine());
            ServerPost collect=new ServerPost();
            collect.Controller(name,age);


        }
    }
}