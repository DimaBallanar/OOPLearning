using MyClasses;
namespace Wallets;

public class Wallet
{
    public decimal Money{get;private set;}
    public readonly WalletTypes Types;
    public Wallet(WalletTypes type,decimal money=0)
    {
        Types=type;
        Money=money;
    }

   

    public void PushMoney(decimal money)
    {
        Money += money;
        System.Console.WriteLine($"вы закинули себе {Money}");
    }

    public bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= Money;
            System.Console.WriteLine($"мы сняли {sum} и осталось {Money}");
            return true;
        }
        System.Console.WriteLine("не достаточно средств");
        return false;
    }
}