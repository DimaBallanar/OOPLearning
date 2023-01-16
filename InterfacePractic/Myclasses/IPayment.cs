namespace MyClasses;

public interface IPayments
{
    decimal Money { get; }

    void PushMoney(decimal money);
     bool TryGetMoney(decimal sum);

}