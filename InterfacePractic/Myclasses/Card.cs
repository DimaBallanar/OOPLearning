namespace Cards;

public class Card
{
    public decimal Money { get; private set; }
    public string Id { get; private set; }

    public Card(string id, decimal money=0)
    {
        Money = money;
        Id = id;
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