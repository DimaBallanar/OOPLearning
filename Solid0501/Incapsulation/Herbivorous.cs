namespace AllAnimals;

public class Herbivorous : Animals   //всеядный
{
    public string Type
    {
        get { return "травоядный"; }
    }
    public Herbivorous(string name, string typeOfFood,double countFood,string TypeOfAnimal) : base(name,typeOfFood,countFood)
    {

    }
}