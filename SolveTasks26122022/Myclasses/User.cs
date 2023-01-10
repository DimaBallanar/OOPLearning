

namespace UserOBD;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {

        return $"ID : {Id}, Name: \"{Name}\", Age : {Age}";
    }
}