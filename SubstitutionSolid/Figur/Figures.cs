namespace Figur;

public class Figures
{
    public string Name { get; private set; }
    public Figures(string name)
    {
        Name = name;
    }
    public virtual void Square()
    {
        System.Console.WriteLine($"площадь фигуры {Name} не определена");
    }
}