//  Класс Покупатель: Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки,
// Номер банковского счета; Конструктор; Методы: установка значений атрибутов,
// получение значений атрибутов, вывод информации. Создать массив объектов
// данного класса. Вывести список покупателей в алфавитном порядке и список
// покупателей, у которых номер кредитной карточки находится в заданном
// диапазоне.

using UserBuyersOBD;
namespace BuyerDataSpace;

public class BuyerData
{
    private UserBuyers[] Array;
    // private string FirstName { get; set; }    //имя
    // private string SecondName { get; set; }   //фамилия
    // private string Patronymic { get; set; }   //отчество

    // private string Addres { get; set; }
    // private ulong CreditCard { get; set; }
    // private int BankAccount { get; set; }

    // public BuyerData(string firstName, string secondname, string patronymic, string adress, ulong creditCard, int bankAccount)
    // {
    //     FirstName = firstName;
    //     SecondName = secondname;
    //     Patronymic = patronymic;
    //     Addres = adress;
    //     CreditCard = creditCard;
    //     BankAccount = bankAccount;
    // }
    public BuyerData()
    {
        Array = new UserBuyers[4];
        // {
        //     array[0] = new UserBuyers("дима", "Пупкин", "владимирович", "игуменский тракт 47 квартира 75", 000000001, 1223);
        //     array[1] = new UserBuyers("вася", "Грач", "Степанович", "игуменский тракт 44 квартира 75", 000666000, 1223);
        //     array[2] = new UserBuyers("петя", "Топор", "Васильевич", "игуменский тракт 98 квартира 75", 100000000, 1223);
        //     array[3] = new UserBuyers("коля", "Корыто", "Георгиевич", "игуменский тракт 4 квартира 75", 123400001, 1223);
        // };
        {
            Array[0] = new UserBuyers() { FirstName = "дима", SecondName = "Пупкин", Patronymic = "владимирович", Addres = "игуменский тракт 47 квартира 75", CreditCard = 000000001, BankAccount = 1223 };
            Array[1] = new UserBuyers() { FirstName = "вася", SecondName = "Грач", Patronymic = "Степанович", Addres = "игуменский тракт 44 квартира 75", CreditCard = 000666000, BankAccount = 1224 };
            Array[2] = new UserBuyers() { FirstName = "петя", SecondName = "Топор", Patronymic = "Васильевич", Addres = "игуменский тракт 98 квартира 75", CreditCard = 100000000, BankAccount = 1225 };
            Array[3] = new UserBuyers() { FirstName = "коля", SecondName = "Корыто", Patronymic = "Георгиевич", Addres = "игуменский тракт 4 квартира 75", CreditCard = 123400001, BankAccount = 1226 };
        }
    }

    public void SortABC()
    {
        string[] names = new string[Array.Length];
        for (int k = 0; k < Array.Length; k++)
        {
            names[k] = Array[k].SecondName;
        }
        string[] temp = new string[Array.Length];
        string help;
        string alfavit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        // string[] alfavit = {"а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я"};
        for (int i = 0; i < names.Length; i++)
        {
            for (int j = i + 1; j < Array.Length; j++)
            {
                if (alfavit.IndexOf(names[i][0]) > alfavit.IndexOf(names[j][0]))
                {
                    help = names[i];
                    names[i] = names[j];
                    names[j] = help;
                }
                else if (alfavit.IndexOf(names[i][0]) == alfavit.IndexOf(names[j][0]) && (alfavit.IndexOf(names[i][1])) > alfavit.IndexOf((names[j][1])))
                {
                    help = names[i];
                    names[i] = names[j];
                    names[j] = help;
                }
            }

        }
        //  for (int i = 0; i < Array.Length; i++)
        // {
        //     for (int j = i + 1; j < Array.Length; j++)
        //     {
        //         a = (Array[i].SecondName)[0];
        //         b = (Array[j].SecondName)[0];
        //         if (alfavit.IndexOf(a) > alfavit.IndexOf(b))
        //         {
        //             help = Array[i].SecondName;
        //             temp[i] = Array[j].SecondName;
        //             temp[j] = help;
        //         }
        //         else if (alfavit.IndexOf(a) == alfavit.IndexOf(b) && (alfavit.IndexOf((Array[i].SecondName)[1])) > alfavit.IndexOf(((Array[j].SecondName)[1])))
        //         {
        //             help = Array[i].SecondName;
        //             temp[i] = Array[j].SecondName;
        //             temp[j] = help;
        //         }
        //     }

        // }
        System.Console.WriteLine(string.Join(',', names));
    }

    public void SortNumberCard()
    {
        System.Console.WriteLine("введите нижний порог значений");
        ulong x = Convert.ToUInt64(Console.ReadLine());
        System.Console.WriteLine("введите верхний порог значений");
        ulong y = Convert.ToUInt64(Console.ReadLine());
        for (int i = 0; i < Array.Length; i++)
            if (x < Array[i].CreditCard && Array[i].CreditCard > y)
            {
                System.Console.WriteLine(Array[i].FirstName);
            }

    }
}