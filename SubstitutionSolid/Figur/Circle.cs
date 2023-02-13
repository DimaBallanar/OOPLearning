namespace Figur;

public class Circle : Figures
{
    private double Radius;

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }
    public override void Square()
    {
        double square = Math.PI * Radius * Radius;
        System.Console.WriteLine($"{this} square ={square:N2}");
    }
    public override string ToString()
    {
        return $"Circle {Name}";
    }
}