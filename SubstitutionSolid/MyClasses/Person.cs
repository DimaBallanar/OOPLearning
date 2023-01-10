namespace Myclasses.Person;

public class Person
{
    public string Name;
    public string Adress;
    public string TelNumber;


    public Person()
    {

    }
    public Person(string number)
    {
        number = GetNumber();

    }

    public Person(string name, string adress, string number)
    {
        Name = GetName();
        Adress = GetAdress();
        TelNumber = GetNumber();

    }

    public string GetName()
    {
        System.Console.Write("Введите свое имя: ");
        string? name = Convert.ToString(Console.ReadLine());
        return name;
    }

    public string GetAdress()
    {
        System.Console.Write("Введите свой адрес: ");
        string? adress = Convert.ToString(Console.ReadLine());
        return adress;
    }

    public string GetNumber()
    {
        System.Console.Write("Введите свой номер телефона: ");
        string? number = Convert.ToString(Console.ReadLine());
        return number;
    }
}

