using Myclasses.Employee;

public class ProductionWorker:Employee
{
    public int WorkPeriod{get;set;}
    public double MoneyPerHour{get;set;}

    public ProductionWorker(string name,int number,int workperiod,double money):base(name,number)
    {
        WorkPeriod=workperiod;
        MoneyPerHour=money;
    }
}