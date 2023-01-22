// 8. Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес,
// Номер кредитной карточки, Дебет, Кредит, Время междугородных и городских
// переговоров; Конструктор; Методы: установка значений атрибутов, получение
// значений атрибутов, вывод информации. Создать массив объектов данного
// класса. Вывести сведения относительно абонентов, у которых время городских
// переговоров превышает заданное. Сведения относительно абонентов, которые
// пользовались междугородной связью. Список абонентов в алфавитном порядке.

namespace AbonentOBD;

public class AbonentOBD
{
    public string FirstName { get; set; }    //имя
    public string SecondName { get; set; }   //фамилия
    public string Patronymic { get; set; }
    public string Addres { get; set; }
    public ulong CreditCard { get; set; }
    public int Debet { get; set; }
    public int Credit { get; set; }
    public int RepublicTime { get; set; }
    public int CityTime { get; set; }
    
    public  AbonentOBD()
    {

    }

    public AbonentOBD(string firstName,string secondname,string patronymic,string adress,ulong creditCard,
    int debet,int credit,int republicTime,int cityTime)
    {
        FirstName=firstName;
        SecondName=secondname;
        Patronymic=patronymic;
        Addres=adress;
        CreditCard=creditCard;
        Debet=debet;
        Credit=credit;
        RepublicTime=republicTime;
        CityTime=cityTime;
    }

    public  void GetName()
}