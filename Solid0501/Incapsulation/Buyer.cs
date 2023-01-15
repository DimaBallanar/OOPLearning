//  Класс Покупатель: Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки,
// Номер банковского счета; Конструктор; Методы: установка значений атрибутов,
// получение значений атрибутов, вывод информации. Создать массив объектов
// данного класса. Вывести список покупателей в алфавитном порядке и список
// покупателей, у которых номер кредитной карточки находится в заданном
// диапазоне.

namespace BuyerData;

public class BuyerData
{
    private string FirstName;    //имя
    private string SecondName;  //фамилия
    private string Patronymic;  //отчество

    private string Addres;
    private ulong CreditCard;
    private int BankAccount;

    public BuyerData(string firstName, string secondname, string patronymic, string adress, ulong creditCard, int bankAccount)
    {
        FirstName = firstName;
        SecondName = secondname;
        Patronymic = patronymic;
        Addres = adress;
        CreditCard = creditCard;
        BankAccount = bankAccount;
    }
    public BuyerData()
    {
        BuyerData[] array = new BuyerData[4];
        {
            array[0] = new BuyerData("дима", "Пупкин", "владимирович", "игуменский тракт 47 квартира 75", 000000001, 1223);
            array[1] = new BuyerData("вася", "Грач", "Степанович", "игуменский тракт 44 квартира 75", 000666000, 1223);
            array[2] = new BuyerData("петя", "Топор", "Васильевич", "игуменский тракт 98 квартира 75", 100000000, 1223);
            array[3] = new BuyerData("коля", "Корыто", "Георгиевич", "игуменский тракт 4 квартира 75", 123400001, 1223);
        };
    }

    public string ABC(BuyerData[] array)
    {
        string temp="";
        string a="";
        string b="";
        string alfavit="абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        for(int i=0;i<array.Length;i++)
        {
           for(int j=i+1;j<array.Length;j++)
           {
            a=array[i][1][0];
            if()
           }

        }
        return result;
    }




}