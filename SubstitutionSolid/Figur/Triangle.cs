namespace Figur;

public class Triangle : Figures
{
    private double A;
    private double B;
    private double C;

    public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
    {
        A = sideA;
        B = sideB;
        C = sideC;

    }

    public override void Square()
    {
        double p = (A + B + C) / 2;
        double square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        System.Console.WriteLine($"{this} square ={square}");
    }
    public override string ToString()
    {
        return $"Triangle {Name}";
    }
}