using System;

namespace AppTransaction.SharedModels;

public class User
{
    public int Id { get; }
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

    public override string ToString()
    {
        return $"{Id} {Name}";
    }
}