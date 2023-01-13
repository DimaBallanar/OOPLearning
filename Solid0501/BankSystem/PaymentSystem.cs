namespace PaymentSystems;

public abstract class AccountPayment
{
    protected decimal Money;
    public string Number { get; private set; }

    public AccountPayment(string number)
    {
        Number = number;
    }

    public AccountPayment(string number, decimal money) : this(number)
    {
        Money = money;
    }

    public abstract bool Payment(string information, decimal request);

    public virtual decimal SetMoney(decimal money)
    {
        Money += money;
        System.Console.WriteLine($"{money} return on your account");
        return default;
    }
}