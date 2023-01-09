using Myclasses.Employee;



public class ProductionWorker : Employee
{
    public int WorkPeriod;
    public double MoneyPerHour;

    public ProductionWorker()
    {

    }
    public ProductionWorker(string name, int number, string workperiod) : base(name, number)
    {
        WorkPeriod = Period();
        MoneyPerHour = CashMoney();
    }
    public int Period()
    {
        System.Console.WriteLine("введите смену в которую вы работаете? дневная/вечерняя");
        string? text = Convert.ToString(Console.ReadLine());

        if (text == "дневная") { return 1; }

        else { return 2; }

    }
    public double CashMoney()
    {
        if (WorkPeriod == 1) { return 8.2; }
        else { return 20; }

    }
    public void Print()
    {
        System.Console.WriteLine($"Имя: {Name}");
        System.Console.WriteLine($"Личный номер: {Number}");
        System.Console.WriteLine($"смена :{WorkPeriod}");
        System.Console.WriteLine($"почасовая оплата {MoneyPerHour}");
    }

}