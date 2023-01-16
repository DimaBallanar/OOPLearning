using Wallets;
namespace MyClasses;

public class CryptoWallet : Wallet
{
    public CryptoWallet(decimal money) : base(WalletTypes.Crypto, money)
    {

    }
    public override bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            System.Console.WriteLine($"мы сняли {sum} с криптокошелька и осталось {Money}");
            return true;
        }
        System.Console.WriteLine("не достаточно средств");
        return false;
    }
}