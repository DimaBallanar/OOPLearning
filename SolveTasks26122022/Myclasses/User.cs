

namespace UserOBD;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    

public void Print(int id,string name,int age)
    {
        
         System.Console.WriteLine($"ID : {Id}, Name: \"{Name}\", Age : {Age}");
    } 
}