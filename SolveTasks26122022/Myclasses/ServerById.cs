// 4. Реализуйте класс ServerById. Обязательными методами считаются методы
// Middleware, Controller, Service, Repository. Цепочка взаимодействия между
// методами следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// на вход подается параметр id
// Необходимо вывести в консоль найденный элемент массива по id если таковой
// имеется. В противном случае бросить исключение. Добавить проверки 

using UserOBD;

namespace ServerBy;

public class ServerByld
{
    private User[] User;

    public ServerByld()
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
    public User Controller(int id)
    {
        if (Middleware(id))
        {
            return Service(id);
        }
        else
        {
            Console.WriteLine("Error not coo");
            return null;
        }
    }
    public User Service(int id)
    {
        User User = Repository(id);
        if (User == null)
        {
            Console.WriteLine("Not found data");
        }
        return User;
    }
    public User Repository(int id)
    {
        foreach (User User in User)
        {
            if (User.Id == id)
            {
                return User;
            }
        }
        return null;
    }

}


