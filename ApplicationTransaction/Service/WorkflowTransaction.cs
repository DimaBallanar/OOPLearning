using AppTransaction.SharedModels;

namespace AppTransaction.Service;

public class WorkflowTransaction
{
    private Transaction[] Transactions;

    public WorkflowTransaction()
    {
        Transactions = new Transaction[2]
        {

          new Transaction(1,23,"Pokupka cola",2,DateTime.Now.AddDays(-1)),
          new Transaction(2,1,"pokupka TV",350,DateTime.Now.AddDays(-1)),
        };
    }
    public void SendTransaction(User user, string comment, decimal value)
    {
        Transaction[] arrayTemp = new Transaction[Transactions.Length + 1];
        Array.Copy(Transactions, arrayTemp, Transactions.Length);
        arrayTemp[arrayTemp.Length - 1] = new Transaction(arrayTemp.Length, user.Id, comment, value, DateTime.Now.AddDays(0));
        Transactions = arrayTemp;

    }
    public void Show(User user)
    {
        bool check = true;
        for (int i = 0; i < Transactions.Length; i++)
        {
            if (Transactions[i].UserId == user.Id)
            {
                check = false;
                System.Console.WriteLine(Transactions[i]);
            }
        }
        if (check)
        {
            System.Console.WriteLine("нет данных по транзакциям пользователя");
        }
    }

}