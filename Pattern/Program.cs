using System;

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
    interface EuroSocket
    {
        void GetPower();
    }
    class SocketAdapter:EuroSocket
    {
        AmericanSocket americanSocket;
        public SocketAdapter(AmericanSocket americanSocket)
        {
            this.americanSocket = americanSocket;
        }
        public  void GetPower()
        {
            americanSocket.GetPower();
        }
    }
    interface AmericanSocket
    {
        void GetPower();
    }
    class SimpleAmericanSOcket:AmericanSocket
    {
        public  void GetPower()
        {
            Console.WriteLine("110 вольт");
        }
    }
    class Radio                     // радио вилка европейская,а хотим врубить в америке
    {
        public void ListenMusic(EuroSocket euroSocket) 
        {
            euroSocket.GetPower();
        }
    }

}