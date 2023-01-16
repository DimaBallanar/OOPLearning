using MyClasses;
namespace Wallets;

public abstract class Wallet : IPayments
{
    public decimal Money { get; protected set; }
    public readonly WalletTypes Types;
    public Wallet(WalletTypes type, decimal money = 0)
    {
        Types = type;
        Money = money;
    }



    public void PushMoney(decimal money)
    {
        Money += money;
        System.Console.WriteLine($"вы закинули себе {Money}");
    }

    public abstract bool TryGetMoney(decimal sum);
    
}