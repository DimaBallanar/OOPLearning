using Myclasses.Employee;

public class ProductionWorker : Employee
{
    public int WorkPeriod { get; set; }
    public double MoneyPerHour { get; set; }

    public ProductionWorker(string name, int number, int workperiod, double money) : base(name, number)
    {
        WorkPeriod = workperiod;
        MoneyPerHour = money;
    }
    public int Period(string text)
    {
        System.Console.WriteLine("введите смену в которую вы работаете? дневная/вечерняя/ночная");

        if (text == "дневная") { return 1; }

        if (text == "вечерняя") { return 2; }
        else { return 3; }
    }
    public double CashMoney(int workperiod)
    {
        if (workperiod == 1) { return 8.2; }
        if (workperiod == 2) { return 10; }
        else { return 20; }

    }

}