using System;
using Pattern;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AmericanSocket socket= new SimpleAmericanSOcket();
            Radio radio=new Radio();
            EuroSocket euroSocket= new SocketAdapter(socket);
            radio.ListenMusic(euroSocket);
        }
    }
    

}