using AppTransaction.SharedModels;
using AppTransaction.Service;
using Registration.Service;
namespace AppTransaction.Core;

public class ApplicationTransaction

{
    private User[] Users;

    public ApplicationTransaction()
    {
        Users = new User[4]{
        new User(1,"test1","test2","1111@gmail.com"),
        new User(2, "test2", "test2", "2111@gmail.com"),
        new User(3, "test3", "test2", "3111@gmail.com"),
        new User(4, "test4", "test2", "4111@gmail.com"),
    };
    }

    public void SignIn()
    {
        Autorization autorization = new Autorization();
        if (autorization.Login(Users, out User? user))
        {
            System.Console.WriteLine(user);
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            workflowTransactions.Show(user);

        }

    }
}