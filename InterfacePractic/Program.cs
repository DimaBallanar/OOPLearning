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

     
            System.Console.WriteLine("введите строку");
            string? text = Console.ReadLine();
            TryParse(text, out int result);
            System.Console.WriteLine(result);
            Method(new int[] {  2, 3 }, 2);

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

        static bool Method(int[] array, int length)
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += 1 / (double)array[i];
                }
                if (sum < 1)
                {
                    throw new Exception("наше число меньше единицы");
                }
                System.Console.WriteLine(sum);
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine("Uncorrcect index");
                return false;
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("NullReference");
                return false;
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Ne deli na nol");
                return false;              
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                System.Console.WriteLine("финал");
            }
        }
    }
}