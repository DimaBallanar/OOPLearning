namespace UserBuyersOBD;

public class UserBuyers
{
    public string FirstName { get; set; }    //имя
    public string SecondName { get; set; }   //фамилия
    public string Patronymic { get; set; }   //отчество

    public string Addres { get; set; }
    public ulong CreditCard { get; set; }
    public int BankAccount { get; set; }
    // public UserBuyers(string firstName, string secondname, string patronymic, string adress, ulong creditCard, int bankAccount)
    // {
    //     FirstName = firstName;
    //     SecondName = secondname;
    //     Patronymic = patronymic;
    //     Addres = adress;
    //     CreditCard = creditCard;
    //     BankAccount = bankAccount;
    // }

    // public override string ToString()
    // {

    //     return $"ID : {Id}, Name: \"{Name}\", Age : {Age}";
    // }
}