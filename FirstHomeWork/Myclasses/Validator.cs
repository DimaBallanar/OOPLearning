// 5. Реализуйте класс Validator. У него будет метод IsEmail параметром принимает
// строку и проверяет, является ли она корректным емейлом или нет. Если является
// - возвращает true, если не является - то false.
// 6. Дополнить 5 задание. Добавить метод IsURL для проверки на url.
// 7. Дополнить 5 задание. Добавить метод IsDate для проверки на дату.
// 8. Дополнить 5 задание. Добавить метод IsPhone для проверки на номер телефона.

namespace HomeWorkFirst.Myclasses;

public class Validator
{

    public string email;

   public bool CheckEmail(string text)
        {
            int countSobak = 0;
            foreach (char a in text)
            {
                if (a == '@' && countSobak < 2)
                {
                    countSobak += 1;
                }
                else
                {
                    return false;
                }
            }
            string[] massiv = text.Split('@');
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

}