namespace Figur;

public class Rectangle : Figures
{
    private double WidhtA;
    private double WidhtB;

    public Rectangle(string name, double widhtA, double widhtB) : base(name)
    {
        WidhtA = widhtA;
        WidhtB = widhtB;
    }

    public override void Square()
    {
        double square = WidhtA * WidhtB;
        System.Console.WriteLine($"{this} square ={square}");
    }
    public override string ToString()
    {
        return $"Rectangle {Name}";
    }
}
