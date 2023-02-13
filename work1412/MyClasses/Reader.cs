// Определить класс Reader, хранящий такую информацию о+
// пользователе библиотеки:
// ФИО,+
// номер читательского билета,+
// факультет,+
// дата рождения,+
// телефон.+
// Методы TakeBook(), ReturnBook().
// Перегрузить методы TakeBook (), ReturnBook ():
// - TakeBook, который будет принимать количество взятых книг.
// Выводит на консоль сообщение "XXX взял Y книги".

// - TakeBook, который будет принимать переменное количество
// названий книг. Выводит на консоль сообщение "XXX взял книги:
// BooK1, BooK2, BooK3".

// - TakeBook, который будет принимать переменное количество
// объектов класса Book (создать новый класс, содержащий имя и
// автора книги). Выводит на консоль сообщение " XXX взял книги:
// BooK1, BooK2, BooK3".
// Аналогичным образом перегрузить метод ReturnBook (). Выводит
// на консоль сообщение "XXX вернул книги: BooK1, BooK2, BooK3".
// Или " XXX вернул Y книги".
// Cоздается массив объектов данного класса.

namespace OOPTask2;

public class Reader
{
    public string Name { get; set; }
    public int NumberCard { get; set; }
    public string Facult { get; set; }
    public string BirthDay { get; set; }
    public string TelephoneNumber { get; set; }

    public void TakeBook(int countBook)
    {
        System.Console.WriteLine($"{Name} взял {countBook} книги");
    }

    public void ReturnBook(int countBook)
    {
        System.Console.WriteLine($"{Name} вернул {countBook} книги");
    }

    


}