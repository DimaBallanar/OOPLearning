using Myclasses;

namespace DataS;

public class Server : Dd
{
    private UserOBD[] User;

    public Server()
    {

    }
    public UserOBD[] CreateUser(string name, string surname, string email, string password)
    {
        UserOBD[] add = new UserOBD[User.Length + 1];
        Array.Copy(User, add, User.Length);
        add[User.Length] = new UserOBD() { Name = name, SurName = surname, Email = email, Password = password };
        User = add;
        return User;

    }
}