namespace AllAnimals;

public class Omnivorous:Animals   //всеядный
{
public string Type
    {
        get { return "всеядный"; }
    }
 public Omnivorous(string name, string typeOfFood,double countFood,string TypeOfAnimal) : base(name,typeOfFood,countFood)
    {
        
    }
}