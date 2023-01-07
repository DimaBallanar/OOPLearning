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
        System.Console.WriteLine("введите смену в которую вы работаете? дневная/вечерняя");

        if (text == "дневная") { return 1; }

        else { return 2; }

    }
    public double CashMoney(int workperiod)
    {
        if (workperiod == 1) { return 8.2; }
        else { return 20; }

    }
     public void Print()
    {
         Console.WriteLine($"Имя: {Name}, Личный номер: {Number}, смена :{WorkPeriod}, почасовая оплата {MoneyPerHour}");
    }

}