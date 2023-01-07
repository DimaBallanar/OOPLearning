namespace Myclasses.Employee;

public class Employee
{
    public string Name{get;set;}
    public int Number{get;set;}

    public Employee(string name)
    {
        Name=name;
        
    }

    public Employee(string name,int number):this(name)
    {
        Number=number;
    }
}