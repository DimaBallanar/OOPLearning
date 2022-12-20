using AppTransaction.Core;
namespace Registration.Service;

public class Registration
{
    private readonly int[] IdUserMass;
    public int IdUser { get; set; }
    public string Name ;
    public string Password ;
    public string Email ;


    public Registration(int id, string name, string password, string email)
    {
        IdUser = id;
        Name = name;
        Password = password;
        Email = email;
    }
    static int[] MassId()
    {
        int[] massiv = new int[100];

        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] += i;
        }
        return massiv;
    }
    static int GetIdUser(string name,ref int[] massId)
    {
        int id;
        if (!string.IsNullOrEmpty(name))
        {

        }

        int[] massiv = new int[100];

        for (int i = 0; i < massiv.Length; i++)
        {
            massiv[i] += i;
        }

        return id;
    }
}