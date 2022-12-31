// 5. Реализуйте класс Validator. У него будет метод IsEmail параметром принимает
// строку и проверяет, является ли она корректным емейлом или нет. Если является
// - возвращает true, если не является - то false.
// 6. Дополнить 5 задание. Добавить метод IsURL для проверки на url.
// 7. Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
// 8. Дополнить 5 задание. Добавить метод IsPhone для проверки на номер телефона.

namespace HomeWorkFirst.Myclasses;

public class Validator
{

    public string Email;

    public Validator(string email)
    {
        Email = email;

    }

    public bool CheckEmail()
    {
        int countSobak = 0;
        foreach (char a in Email)
        {
            if (a == '@')
            {
                countSobak += 1;
            }
            else if (countSobak > 1 || countSobak < 1)
            {
                return false;
            }
        }
        string[] massiv = Email.Split('@');
        string myCheck = massiv[1];
        string[] result = myCheck.Split('.');
        if (result.Length == 2 && result[1].Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsURL()
    {
        // bool result = false;
        bool result=Email.Contains("http")?true:false;
        // if (Email.Contains("http"))
        // {
        //     result = true;
        // }
        return result;
    }

    public bool IsDate()
    {
        bool result =false;
        if(Email.Contains('/')||Email.Contains('-')||Email.Contains('.'))
        {
            result=true;
        }
        return result;
    }

    public bool IsPhone()
    {
        bool result = false;
        if (Email.StartsWith("+375") || Email.StartsWith("80"))
        {
            result = true;
        }
        return result;
    }

}