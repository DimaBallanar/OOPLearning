using Myclasses.Person;

public class Customer : Person
{
    public int ClientId = 1;
    public bool Sms;

    public Customer(string name, string adress, string number, int clientId, bool call) : base(name, adress, number)
    {
        ClientId = GetId(ref ClientId);
        Sms = CheckCall();
    }

    static int GetId(ref int ClientId)
    {
        int id = ClientId;
        ClientId++;
        return id;
    }

    public bool CheckCall()
    {
        System.Console.Write("делать ли Вам рассылку?да/нет");
        string? check = Convert.ToString(Console.ReadLine());
        if (check == "да")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}