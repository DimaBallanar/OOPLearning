using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    interface EuroSocket
    {
        void GetPower();
    }
    class SocketAdapter : EuroSocket
    {
        AmericanSocket americanSocket;
        public SocketAdapter(AmericanSocket americanSocket)
        {
            this.americanSocket = americanSocket;
        }
        public void GetPower()
        {
            americanSocket.GetPower();
        }
    }
    interface AmericanSocket
    {
        void GetPower();
    }
    class SimpleAmericanSOcket : AmericanSocket
    {
        public void GetPower()
        {
            Console.WriteLine("работаем от 110 вольт");
        }
    }
    class Radio                     // радио вилка европейская,а хотим врубить в америке
    {
        public void ListenMusic (EuroSocket euroSocket)
        {
            euroSocket.GetPower();
        }
    }

}