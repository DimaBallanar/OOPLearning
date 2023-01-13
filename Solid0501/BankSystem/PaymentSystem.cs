namespace PaymentSystems;

public abstract class AccountPayment
{
    protected decimal Money;
    public readonly List<string> History=new List<string>();
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
    public abstract decimal SetMoney(decimal money);

    public override string ToString()
    {
        return $"Name : {Number} money : {Money}";
    }
}