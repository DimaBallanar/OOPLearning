// 8. Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес,
// Номер кредитной карточки, Дебет, Кредит, Время междугородных и городских
// переговоров; Конструктор; Методы: установка значений атрибутов, получение
// значений атрибутов, вывод информации. Создать массив объектов данного
// класса. Вывести сведения относительно абонентов, у которых время городских
// переговоров превышает заданное. Сведения относительно абонентов, которые
// пользовались междугородной связью. Список абонентов в алфавитном порядке.

namespace AbonentOBD;

// public class AbonentOBD
// {
//     public string FirstName { get; set; }    //имя
//     public string SecondName { get; set; }   //фамилия
//     public string Patronymic { get; set; }
//     private string _addres;
//     public ulong CreditCard { get; set; }
//     public int Debet { get; set; }
//     public int Credit { get; set; }
//     public int RepublicTime { get; set; }
//     public int CityTime { get; set; }

//     public AbonentOBD()
//     {

//     }

//     public AbonentOBD(string firstName, string secondname, string patronymic, string adress, ulong creditCard,
//     int debet, int credit, int republicTime, int cityTime)
//     {
//         FirstName = firstName;
//         SecondName = secondname;
//         Patronymic = patronymic;
//         _addres = adress;
//         CreditCard = creditCard;
//         Debet = debet;
//         Credit = credit;
//         RepublicTime = republicTime;
//         CityTime = cityTime;
//     }

//     public string GetAddres()
//     {
//         return _addres;

//     }
//     public void SetAddres(string adress)
//     {
//         if (string.IsNullOrEmpty(adress))
//         {
//             throw new ArgumentNullException(nameof(adress));
//         }
//         _addres = adress;
//     }
// }

public class OutClass<T, K>
{
    public T PropertyT;
    public K PropertyK;

    public OutClass(T propertyT, K propertyK)
    {
        if (propertyT == null) throw new ArgumentNullException(nameof(propertyT));
        if (propertyK == null) throw new ArgumentNullException(nameof(propertyK));
        PropertyT = propertyT;
        PropertyK = propertyK;
    }
    public void SetPropertyT(T propertyT)
    {
        PropertyT = propertyT;
    }
    public void SetPropertyK(K propertyK)
    {
        PropertyK = propertyK;
    }

    public void Show()
    {
        System.Console.WriteLine($"{PropertyT.ToString()} {PropertyK.ToString()}");
    }

}