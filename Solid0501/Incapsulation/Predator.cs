namespace AllAnimals;

public class Predator : Animals
{
    public string TypeOfAnimal
    {
        get { return "хищник"; }
    }
    public Predator()
    {

    }

    public Predator(string name, string typeOfFood, double countFood, string typeOfAnimal) : base(name, typeOfFood, countFood)
    {
        
    }



}