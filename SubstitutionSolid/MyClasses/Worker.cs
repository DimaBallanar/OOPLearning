using Myclasses.Person;

namespace Myclasses.Worker;

public class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Worker()
    {

    }

    public Worker(string name, string surname)
    {
        Name = GetName();
        Surname = surname;
    }

    public string GetName()
    {
        System.Console.Write("Введите свое имя: ");
        string? name = Convert.ToString(Console.ReadLine());
        return name;
    }
    public string GetSurname()
    {
        System.Console.Write("Введите свое фамилию: ");
        string? name = Convert.ToString(Console.ReadLine());
        return name;
    }

    public void GetFullName()
    {
        System.Console.WriteLine($"{Name} {Surname}");
    }

}