using AppTransaction.SharedModels;
using AppTransaction.Service;
namespace AppTransaction.Core;

public class ApplicationTransaction

{
    private User[] Users;

    public ApplicationTransaction()
    {
        Users = new User[4]{
        new User(1,"test1","test2","1111@gmail.com"),
        new User(2, "test2", "test2", "1111@gmail.com"),
        new User(3, "test3", "test2", "1111@gmail.com"),
        new User(4, "test4", "test2", "1111@gmail.com"),
    };
    }

    public void Work()
    {
        Autorization autorization = new Autorization();
    }
}