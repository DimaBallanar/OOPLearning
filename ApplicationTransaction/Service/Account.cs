using AppTransaction.SharedModels;
namespace AppTransaction.Service;

public class Account
{
    private int NextIdUser = 1;
    private User[] Users;
    public Account()
    {
        {
            Users = new User[20];

            Users[0] = new User(NextIdUser++, "test1", "test2", "1111@gmail.com");
            Users[1] = new User(NextIdUser++, "test2", "test2", "2111@gmail.com");
            Users[2] = new User(NextIdUser++, "test3", "test2", "3111@gmail.com");
            Users[3] = new User(NextIdUser++, "test4", "test2", "4111@gmail.com");

        }
    }
    public bool Login(out User? user)
    {
        System.Console.Write("введите email:");
        string? email = Console.ReadLine();
        System.Console.Write("введите пароль:");
        string? pass = Console.ReadLine();
        user = Search(email, pass);
        return user != null;
    }

    private User? Search(string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("ERROR");
            return null;
        }

        foreach (User user in Users)
        {
            if (user == null) ;
            {
                continue;
            }
            //  if (user?.Email == email && user?.Password == pass)
            if (user.Email == email && user.Password == pass)
            {
                System.Console.WriteLine("Login Succesful");
                return user;

            }
        }
        System.Console.WriteLine("ERROR input");
        return null;

    }
    private User? SearchSimple(string? email, string? pass, string? name)
    {
        if (string.IsNullOrEmpty(email)
 || string.IsNullOrEmpty(pass))//name
        {
            System.Console.WriteLine("error input");
            return null;
        }
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Email == email)//isnull
            {
                System.Console.WriteLine("This email not available");
                return null;
            }
        }
        return new User(NextIdUser++, name, pass, email);

    }
  

}


//проверка на ввод мыла