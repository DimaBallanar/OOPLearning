using Wallets;
using Cards;
namespace MyClasses;


public class Shop
{
    public decimal Money { get; set; }

    public Shop()
    {

    }

    public void PayCash(IPayments item)
    {
        if (decimal.TryParse(Console.ReadLine(), out decimal sum))
        {
            if (item.TryGetMoney(sum))
            {
                Money += sum;
            }
            else
            {
                System.Console.WriteLine("not enough money");
            }
        }

    }
    
}