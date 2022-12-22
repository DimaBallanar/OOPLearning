using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction

{

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
    // public void RegIn(User[] Users,int id, string name, string password,string email)
    // {
    //     User[] timeArray=new User[Users.Length+1];
    //     Array.Copy(Users, timeArray, Users.Length);
    //     timeArray[timeArray.Length - 1] = new Transaction(timeArray.Length, user.Id, comment, value, DateTime.Now.AddDays(0));
    //     Users = timeArray;

    // }
    public void SignIn()
    {
        Account autorization = new Account();
        if (autorization.Login( out User? user))
        {
            System.Console.WriteLine(user);
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            System.Console.WriteLine("введите коментарий");
            string comment = Console.ReadLine();
            System.Console.WriteLine("сколько ?");
            decimal value = Convert.ToDecimal(Console.ReadLine());
            workflowTransactions.SendTransaction(user, comment, value);
            workflowTransactions.Show(user);

        }

    }
}