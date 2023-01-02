using System;
using Server;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerGetAll server=new ServerGetAll();
            server.Controller();
        }
    }
}