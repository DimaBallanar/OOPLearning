// Реализуйте класс ServerPost. Обязательными методами считаются методы
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
// на вход подается параметры name, age
// Необходимо добавить в массив БД объект только в том случае, если нет совпадений
// по name. Если совпадения нет, то в объект клиента добавить ключ Id с последним
// возможным уникальным Id БД, таким образом, чтобы в БД был запушен объект вида
// {“Id": 6, Name : "Test", Age : 1}
// Если совпадение есть – ошибка. Добавить проверки 

using UserOBD;

namespace ServerPo;

public class ServerPost
{

    private User[] User;

    public ServerPost()
    {
        User = new User[4];
        User[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        User[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        User[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        User[3] = new User() { Id = 4, Name = "Germana", Age = 18 };

    }
    public bool Middleware(string name)
    {
        bool result = true;
        if (string.IsNullOrEmpty(name))
        {
            result = false;
        }
        return result;
    }
    public User[] Controller(string name, int age)
    {
        if (Middleware(name))
        {
            return Service(name, age);
        }
        else
        {
            Console.WriteLine("Error");
            return null;
        }
    }
    public User[] Service(string name, int age)
    {
        User[] User = Repository(name, age);
        if (User == null)
        {
            Console.WriteLine("пользователь с таким именем уже существует или указан неверный возраст");
        }

        return User;
    }
    public User[] Repository(string name, int age)
    {
        foreach (User user in User)
        {
            if (user.Name == name)
            {
                return null;
            }
        }
        if (age > 150 || age <= 0)
        {
            return null;
        }
        User[] userTime = new User[User.Length + 1];
        Array.Copy(User, userTime, User.Length);
        userTime[User.Length] = new User() { Id = userTime.Length, Name = name, Age = age };
        User = userTime;
        return User;
    }
}