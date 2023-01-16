using System;
using Cards;
using MyClasses;
using Wallets;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Card card = new Card("1");
            // card.PushMoney(100);
            // card.TryGetMoney(100);       
            // System.Console.WriteLine((int)WalletTypes.Crypto);
            // System.Console.WriteLine((int)WalletTypes.Leather);
            // System.Console.WriteLine((WalletTypes)1);
            IPayments wallet = new LeatherWallet(10);
            wallet.PushMoney(1233);
            Shop shop = new Shop();
            shop.PayCash(wallet);

        }
    }
}