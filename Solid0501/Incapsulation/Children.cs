// Определить класс Children, который содержит такие поля (члены класса): 
// закрытые – имя ребенка, фамилию и возраст , публичные – методы ввода данных 
// и отображения их на экран. Объявить два объекта класса, внести данные и 
// показать их.

namespace Incapsulation;

public class Children
{
    private string Name;
    private string Surname;
    private int Age;


    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }

    public void SetSurName(string surname)
    {
        Surname = surname;
    }
    public string GetSurName()
    {
        return Surname;
    }

    public void SetAge(int age)
    {
        Age = age;
    }
    public int GetAge()
    {
        return Age;
    }
}