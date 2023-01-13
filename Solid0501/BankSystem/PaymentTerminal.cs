namespace PaymentSystems;

public class PaymentTerminal
{
    private string NameTerminal;
    private decimal MoneyTerm;

    public PaymentTerminal(string name)
    {
        NameTerminal = name;
    }
    public void SetMoneyByPaymentSystem(decimal money, AccountPayment account)
    {
        if (account.Payment($"request money from {NameTerminal}", money))
        {
            MoneyTerm += money;
            System.Console.WriteLine("succesful");
        }
        else
        {
            System.Console.WriteLine("нет денег");
        }
    }
    public override string ToString()
    {
        return $"Terminal name : {NameTerminal},money {MoneyTerm}";
    }
}