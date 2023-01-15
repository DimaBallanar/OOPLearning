namespace AllAnimals;

public class Animals
{
    public string Name { get; set; }          // имя

    public string TypeOfFood { get; set; }   //тип пищи
    public double CountFood { get; set; }  //количество пищи

    public Animals()
    {

    }
    public Animals(string name, string typeOfFood, double countFood)
    {
        Name = name;
        TypeOfFood = typeOfFood;
        CountFood = countFood;

    }
    public string GetName()
    {
        System.Console.Write("введите имя животного: ");
        string? name = Convert.ToString(Console.ReadLine());
        return name;
    }

    public double GetFoodCounter()
    {
        System.Console.Write("сколько ест за прием,кг?:");
        double foodPerTime = Convert.ToDouble(Console.ReadLine());
        double countFood = foodPerTime * 3;
        return countFood;
    }

    public string GetTypeOfFood()
    {
        System.Console.Write("чем питается?");
        string typeOfFood = Convert.ToString(Console.ReadLine());
        return typeOfFood;
    }





}