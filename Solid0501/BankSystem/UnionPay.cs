namespace PaymentSystems;

public class UnionPay : AccountPayment
{
    public UnionPay(string number) : base(number)
    {

    }

    public UnionPay(string number, decimal money) : base(number, money)
    {

    }

    public override bool Payment(string information, decimal request)
    {
        request *= (decimal)1.03;
        
        if (Money >= request)
        {
            History.Add($"{information}-{request}");
            Money -= request;
          
            return true;
        }
     
        return false;
    }
    public override decimal SetMoney(decimal money)
    {
        // decimal com = money switch
        // {
        //     < 50 => money * (decimal)0.0001,
        //     < 100 => money * (decimal)0.0005,
        //     < 500 => money * (decimal)0.001,
        //     < 1000 => money * (decimal)0.002,
        //     _ => money * (decimal)0.003
        // };
        // decimal com = 0;        
        // if (money < 50)
        // {
        //     com = money * (decimal)0.0001;
        // }
        // else if (money < 100)
        // {
        //     com = money * (decimal)0.0005;
        // }
        // else if (money < 500)
        // {
        //     com = money * (decimal)0.001;

        // }
        // else if (money < 1000)
        // {
        //     com = money * (decimal)0.002;

        // }
        // else
        // {
        //     com = money * (decimal)0.003;
        // }
        base.SetMoney(money - com);
        return com;
    }
}

// до 50 = 0.01%
// до 100 = 0.05%
// до 500 = 0.1%
// до 1000 = 0.2%
// более 0.3%