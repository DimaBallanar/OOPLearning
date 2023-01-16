using Wallets;
namespace MyClasses;

public class LeatherWallet : Wallet
{
    public LeatherWallet(decimal money) : base(WalletTypes.Leather, money)
    {

    }
    public override bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            System.Console.WriteLine($"мы сняли {sum} с кожаного кошелька и осталось {Money}");
            return true;
        }
        System.Console.WriteLine("не достаточно средств");
        return false;
    }

}