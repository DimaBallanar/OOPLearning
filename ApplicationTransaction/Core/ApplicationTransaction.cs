using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction

{

 
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