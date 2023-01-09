using Myclasses.Worker;

// Класс Singer наследует Name, Surname, также состоит из свойств Years, Birth, Style и метода
// GetMoreInfo(), который выводит информацию о певце: Years, Birth, Style.
// Необходимо вызвать метод GetMoreInfo

public class Singer : Worker
{
    public int Years { get; set; }
    public DateOnly Birth { get; set; }
    public string Style { get; set; }

    public Singer()
    {

    }

    public Singer(string name, string surname, int years, DateOnly birth, string style) : base(name, surname)
    {
        Birth = GetBirth();
        Years = GetYears();
        Style = GetStyle();

    }

    public DateOnly GetBirth()
    {
        System.Console.WriteLine("введите год рождения");
        int x = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("введите месяц рождения");
        int y = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("введите день рождения");
        int z = Convert.ToInt32(Console.ReadLine());
        DateOnly birth = new DateOnly(x, y, z);
        return birth;

    }
    public int GetYears()
    {
        DateTime now = DateTime.Now;
        int years = now.Year - Birth.Year;
        return years;
    }

    public string GetStyle()
    {
        System.Console.Write("стиль исполнения: ");
        string style = Convert.ToString(Console.ReadLine());
        return style;
    }

    public void Print()
    {
        System.Console.WriteLine($"{Name},{Surname},{Years}, {Birth},{Style}");
    }
}