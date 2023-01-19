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
            // IPayments wallet = new LeatherWallet(10);
            // wallet.PushMoney(1233);
            // Shop shop = new Shop();
            // shop.PayCash(wallet);

            // лами while, foreach
            System.Console.WriteLine("введите строку");
            string? text = Console.ReadLine();
            TryParse(text, out int result);
            System.Console.WriteLine(result);

        }
        static bool TryParse(string? text, out int result)
        {

            try
            {
                result = int.Parse(text);
                return true;
            }
            catch (Exception ex)
            {
                result = 0;
                System.Console.WriteLine(ex);
                return false;
            }
        }
    }
}