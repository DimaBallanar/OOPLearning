using System;
using Server;
using ServerBy;
using ServerPo;
using ServerP;
using ServerD;
using Conversion10;
using Conversion2;
using Conversion16;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerGetAll server=new ServerGetAll();
            server.Controller();
            
            // System.Console.Write("укажите id пользователя: ");
            // int id = Convert.ToInt32(Console.ReadLine());
            // ServerByld serv=new ServerByld();
            // serv.Controller(3);
            // System.Console.Write("Введите имя: ");
            // string? name = Convert.ToString(Console.ReadLine());
            // System.Console.Write("Введите возраст: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // ServerPost collect = new ServerPost();
            // collect.Controller(name, age);
            // ServerPut zamena = new ServerPut();
            // zamena.Controller(id, name, age);
            // ServerDelete delete=new ServerDelete();
            // delete.Controller(id);
            // Conversion conv=new Conversion();
            // System.Console.WriteLine("введите число");
            // int numberDis=Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine(conv.ToBinaryNumber(numberDis));
            // System.Console.WriteLine(conv.ToHexadecimalNumber(numberDis));
            // System.Console.WriteLine(conv.ToOctalNumber(numberDis));
            // string? convDi = Convert.ToString(Console.ReadLine());
            // ConversionTwo dva = new ConversionTwo();
            // System.Console.WriteLine(dva.ToDecimalNumber(convDi));
            // System.Console.WriteLine(dva.ToHexadecimalNumber(convDi));
            // System.Console.WriteLine(dva.ToOctalNumber(convDi));
            // System.Console.WriteLine("введите число в 16 ричной системе счисления");
            // string? ypr = Convert.ToString(Console.ReadLine());
            // ConversionSix six = new ConversionSix();
            // System.Console.WriteLine(six.ToDecimalNumber(ypr));
            // System.Console.WriteLine(six.ToBinaryNumber(ypr));








        }
    }
}