using System;


namespace AppTransaction.SharedModels;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public User(int id)
    {
        Id = id;
    }

    public User(int id, string name, string password, string email) : this(id)
    {
        Id = id;
        Name = name;
        Password = password;
        Email = email;
    }
    // public void RegUser(User users,string name, string password, string email)
    // {

    //     Id = GetIdUser();
    //     System.Console.Write("введите свое имя");
    //     Name=Console.ReadLine();
    //     System.Console.Write("введите пароль");
    //     Password=Console.ReadLine();
    //      System.Console.Write("введите своq Email");            

    // }

    // int GetIdUser()
    // {
    //     int idNewUser = Massiv[Massiv.Length - 1];
    //     int[] timeMassiv = new int[Massiv.Length + 1];
    //     Array.Copy(Massiv, timeMassiv, timeMassiv.Length);
    //     timeMassiv[Massiv.Length] = idNewUser + 1;
    //     Massiv = timeMassiv;
    //     return idNewUser;
    // }

    public override string ToString()
    {
        return $"{Id} {Name} {Email}";
    }
}