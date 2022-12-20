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
        new User(2, "test2", "test2", "2111@gmail.com"),
        new User(3, "test3", "test2", "3111@gmail.com"),
        new User(4, "test4", "test2", "4111@gmail.com"),

    };
    }
    public void Chose()
    {
        System.Console.WriteLine("1 or 2");
        int chose = Convert.ToInt32(Console.ReadLine());
        if (chose == 1)
        {
            SignIn();
        }
        else
        {
            // RegIn();
        }


    }
    public void RegIn(ref User[] Users)
    {
        User[] timeArray=new User[Users.Length+1];
        Array.Copy(Users, timeArray, Users.Length);
        timeArray[timeArray.Length - 1] = new Transaction(timeArray.Length, user.Id, comment, value, DateTime.Now.AddDays(0));
        Users = timeArray;

    }
    public void SignIn()
    {
        Autorization autorization = new Autorization();
        if (autorization.Login(Users, out User? user))
        {
            System.Console.WriteLine(user);
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            System.Console.WriteLine("введите коментарий");
            string comment = Console.ReadLine();
            System.Console.WriteLine("сколько ?");
            decimal value = Convert.ToDecimal(Console.ReadLine());
            workflowTransactions.SendTransaction(user,comment,value);
            workflowTransactions.Show(user);

        }

    }
}