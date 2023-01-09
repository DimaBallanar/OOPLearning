namespace Myclasses.Employee;

public class Employee
{
    public string Name;
    public int Number;

    public Employee()
    {

    }
    public Employee(string name)
    {
        Name = name;
    }

    public Employee(string name, int number) : this(name)
    {
        Number = number;
    }

    public string Im9()
    {
        System.Console.Write("введите имя рабочего: ");
        string? name = Convert.ToString(Console.ReadLine());
        return name;
    }

    public int Num()
    {
        System.Console.Write("введите номер рабочего: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

}