// 7. Реализуйте класс ServerDelete. Обязательными методами считаются методы
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
// на вход подается параметр id
// Необходимо осуществить удаление по Id. Если совпадения нет – ошибка. Добавить
// проверки

using UserOBD;

namespace ServerD;

public class ServerDelete
{
    private User[] Users;


    public ServerDelete()
    {
        Users = new User[4];

        Users[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        Users[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        Users[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        Users[3] = new User() { Id = 4, Name = "Germana", Age = 18 };
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
            Console.WriteLine("Error");
            return null;
        }
    }
    public User Service(int id)
    {
        User User = Repository(id);
        if (User == null)
        {
            Console.WriteLine($"пользователя с таким id:{id} не существует");
        }

        return User;
    }
    public User Repository(int id)
    {
        foreach (User user in Users)
        {
            if (user.Id == id)
            {

                return null;
            }
        }
        return null;
    }
}