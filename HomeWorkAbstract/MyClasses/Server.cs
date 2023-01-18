namespace Myclasses;

public class Server : User
{
    public Server(int userId, string name, string surName, string pwd)
    {
        UserId = userId;
        Name = name;
        SurName = surName;
        Pwd = pwd;
    }

    public void GetUser()
    {
        System.Console.WriteLine($"{UserId},{Name},{SurName},{Pwd}");
    }
}