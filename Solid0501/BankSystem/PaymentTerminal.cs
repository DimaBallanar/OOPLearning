namespace PaymentSystems;

public class PaymentTerminal
{
    private string NameTarminal;
    private decimal MoneyTerm;

    public PaymentTerminal(string name)
    {
        NameTarminal=name;
    }
public void SetMoneyByPaymentSystem(decimal money , AccountPayment account)
{
    if(account.Payment(NameTarminal,money))
    {
        MoneyTerm+=money;
        System.Console.WriteLine("succesful");
    }
    else
    {
        System.Console.WriteLine("нет денег");
    }
}
}