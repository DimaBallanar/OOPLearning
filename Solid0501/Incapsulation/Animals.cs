namespace AllAnimals;

public class Animals
{
    public string Name { get; set; }
    public string TypeOfAnimal { get; set; }  // имя
    public string Type { get; set; }   //тип пищи
    public int CountFood { get; set; }  //количество пищи


    public Animals(string name, string typeOfAnimal, int countFood)
    {
        Name = name;
    }

    public virtual string FoodCounter()
    {
        System.Console.Write("сколько ест за прием?:");
        double foodPerTime = Convert.ToDouble(Console.ReadLine());


    }



}