namespace AllAnimals;

public class Predator : Animals
{
    public string Type
    {
        get { return "хищник"; }
    }

    public Predator(string name, string type) : base(name)
    {
        
    }



}