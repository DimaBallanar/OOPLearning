using Myclasses.Employee;



public class ProductionWorker : Employee
{
    public int WorkPeriod { get; set; }
    public double MoneyPerHour { get; }

    public ProductionWorker(string name, int number, string workperiod) : base(name, number)
    {
        WorkPeriod = Period(workperiod);
        MoneyPerHour = CashMoney(workperiod);
    }
    public int Period(string text)
    {
        // System.Console.WriteLine("введите смену в которую вы работаете? дневная/вечерняя");
        // string text=Convert.ToString(Console.ReadLine());

        if (text == "дневная") { return 1; }

        else { return 2; }

    }
    public double CashMoney(string workperiod)
    {
        if (workperiod == "дневная") { return 8.2; }
        else { return 20; }

    }
     public void Print()
    {
         Console.WriteLine($"Имя: {Name}, Личный номер: {Number}, смена :{WorkPeriod}, почасовая оплата {MoneyPerHour}");
    }

}