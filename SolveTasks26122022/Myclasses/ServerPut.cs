// Реализуйте класс ServerPut. Обязательными методами считаются методы
// Middleware, Controller, Service, Repository. Цепочка взаимодействия между методами
// следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// на вход подается параметры id, name, age
// Необходимо найти Id клиента в массиве БД. Если совпадение есть, произвести
// обновление значений для соответствующих ключей.
// Если совпадения по Id нет – ошибка. Добавить проверки 

using UserOBD;

namespace ServerP;

public class ServerPut
{

    private User[] User;


    public ServerPut()
    {
        User = new User[4];

        User[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        User[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        User[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        User[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
    }
    public bool Middleware(int id)
    {

        return id > 0; // true false
    }
    public User Controller(int id, string name, int age)
    {
        if (Middleware(id))
        {
            return Service(id, name, age);
        }
        else
        {
            Console.WriteLine("Error");
            return null;
        }
    }
    public User Service(int id, string name, int age)
    {
        User User = Repository(id, name, age);
        if (User == null)
        {
            Console.WriteLine($"пользователя с таким id:{id} не существует");
        }

        return User;
    }
    public User Repository(int id, string name, int age)
    {
        foreach (User User in User)
        {
            if (User.Id == id)
            {
                User.Name = name;
                User.Age = age;
                System.Console.WriteLine($"ID : {User.Id}, Name: \"{User.Name}\", Age : {User.Age}");
                return User;
            }
        }

        return null;
    }
}