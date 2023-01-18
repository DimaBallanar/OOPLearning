namespace Myclasses;

public class UserOBD
{
    public string Name { get; set; }="DefaulName";
    public string SurName { get; set; }="DefaultSurName";
    public string Email { get; set; }="DefaultEmail";
    public string Password { get; set; }="0000";
    public UserOBD()
    {

    }
    public UserOBD(string name, string surname, string email, string password)
    {
        Name = name;
        SurName = surname;
        Email = email;
        Password = password;
    }

    public override string ToString()
    {

        return $"Name : {Name}, SurName: \"{SurName}\", Email : {Email}";
    }
}