// Создайте класс Phone, который содержит поля Number, Model и
// Weight.
// Создайте три экземпляра этого класса.
// Выведите на консоль значения их полей.
// Добавить в класс Phone методы: ReceiveCall, имеет один
// параметр – имя звонящего. Выводит на консоль сообщение “Звонит
// {name}”. Метод GetNumber – возвращает номер телефона. Вызвать
// эти методы для каждого из объектов.
// Добавить конструктор в класс Phone, который принимает на вход
// три параметра для инициализации полей класса - Number, Model
// и Weight.
// Добавить конструктор, который принимает на вход два параметра
// для инициализации полей класса - - Number, Model.
// Добавить конструктор без параметров.
// Вызвать из конструктора с тремя параметрами конструктор с
// двумя.
// Добавьте перегруженный метод ReceiveCall, который принимает
// два параметра - имя звонящего и номер телефона звонящего.
// Вызвать этот метод.
// Создать метод SendMessage с аргументами переменной длины.
// Данный метод принимает на вход номера телефонов, которым будет
// отправлено сообщение. Метод выводит на консоль номера этих
// телефонов.

namespace OOPTask2;

public class Phone
{
    public string Number = "+37525xxxxxxx";
    public string Model = "None";
    public string Weight = "Empty";

    public Phone()
    {

    }

    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }
    public Phone(string number, string model, string weight)
    {
        Number = number;
        Model = model;
        Weight = weight;
    }
    public void RecieveCall(string name)
    {
        System.Console.WriteLine($"Вам звонит {name}");
    }

    public void SendMessage(string message , params string[] numbers)
    {
        foreach(string item in numbers)
        {
            System.Console.WriteLine(string.Format("Phone:{0} message:{1}",item,message));
        }

    }
    public string GetNumber()
    {
        return Number;
    }

    public override string ToString()
    {
        return string.Join(",", Number, Model, Weight);
    }
}