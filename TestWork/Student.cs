using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{//48.Создайте класс для хранения информации о студенте, включающей имя,
 //фамилию, возраст и номер группы. Реализуйте интерфейс IComparable для
 //сравнения студентов по возрасту.
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }

        public Student(string name, string surname, int age, int group)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Group = group;
        }

        public int CompareTo(Student? student1)
        {
            if (student1 is null) throw new ArgumentException("Некорректное значение параметра");
            if (Age > student1.Age)
            {
                Console.WriteLine($"{Name} старше {student1.Age}");
            }
            else if (Age < student1.Age)
            {
                Console.WriteLine($"{student1.Name} старше {Age}");
            }
            else
            {
                Console.WriteLine($"{student1.Name} одногодка с {Age}");
            }
            return Age - student1.Age;
        }
    }
}
