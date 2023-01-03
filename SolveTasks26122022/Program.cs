using System;
using Server;
using ServerBy;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ServerGetAll server=new ServerGetAll();
            // server.Controller();
            ServerByld serv=new ServerByld();
            serv.Controller(1);
        }
    }
}