using AppTransaction.SharedModels;
namespace AppTransaction.Service;

public class Autorization
{
    public bool Login(User[] users, out User? user)
    {
        System.Console.Write("введите email:");
        string? email = Console.ReadLine();
        System.Console.Write("введите пароль:");
        string? pass = Console.ReadLine();
        user = Search(email, pass, users);
        return user != null;
    }

    private User? Search(string? email, string? pass, User[] users)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("ERROR");
            return null;
        }

        foreach (User user in users)
        {
            if (user.Email == email && user.Password == pass)
            {
                System.Console.WriteLine("Login Succesful");
                return user;

            }
        }
        System.Console.WriteLine("ERROR input");
        return null;

    }

}


//проверка на ввод мыла