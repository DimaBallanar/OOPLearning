using System;
using System.Security.Cryptography.X509Certificates;
using Daily1892;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<User> users = new List<User>();
            //users.Add(new User("Vitya", 0, "+375552322222"));
            //users.Add(new User("Artyom", 1, "+375552366666"));
            //users.Add(new User("Dima", 2, "+37555232444332"));
            //users.Add(new User("Artyom", 3, "+375552366666"));
            //users.Add(new User("Dima", 4, "+37555232444332"));
            //users.Add(new User("Artyom", 5, "+375552366666"));
            //users.Add(new User("Dima", 6, "+37555232444332"));
            //users.Add(new User("Serega", 7, "+375552366666"));
            //users.Add(new User("Vasya", 8, "+37555232444332"));

            ////из листа в диктионари,ключ имя пользвоателя , значение -коллекция пользователей,которая содержит это имя

            //Dictionary<string,List<User>> map = new Dictionary<string, List<User>>();
            //for(int i=0;i<users.Count;i++) 
            //{
            //    User user = users[i];
            //if (map.ContainsKey(users[i].Name)) 
            //{
            //    map[user.Name].Add(user);
            //}
            //else
            //{
            //    map.Add(user.Name, new List<User>() { user });
            //}
            //888888888888888888888888888888888888888888888

            //if (!map.TryGetValue(user.Name, out _))
            //{
            //    map.Add(user.Name, new List<User>());
            //}
            //map[user.Name].Add(user);

            // **********************


            //if (!map.TryGetValue(user.Name, out List<User> values))
            //{
            //    values = new List<User>();
            //    map.Add(user.Name, values);
            //}
            //values.Add(user);
            //}
            //foreach(var key in map.Keys) 
            //{
            //    string text = string.Join(',', map[key]);
            //    Console.WriteLine($"Key:{key} | Value: {text}");

            //}
            //var groupBy = users.GroupBy(user => user.Name).ToDictionary(x=>x.Key,x=>x.ToList());
            //Console.ReadKey();

            Matrix part = new Matrix(3, 4);
            part.Zapolnenie();
            Console.WriteLine();
            part.Reverse();
           

        }
    }
}