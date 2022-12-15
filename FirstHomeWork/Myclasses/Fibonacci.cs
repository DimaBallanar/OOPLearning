// 4. У вас есть класс Fibonacci. Создать в нем функцию для вывода ряда фибоначчи.
// Необходимо добавить проверки.
namespace HomeWorkFirst.Myclasses;

public class Fibonacci
{
    static void Task1()
        {
            System.Console.WriteLine("введите номер элемента с ряда Фиббоначчи");
            int cost = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(FibNumber(cost));
        }
        static int FibNumber(int cost)
        {
            if (cost == 1)
            {
                return 0;
            }
            if (cost == 2 || cost == 3)
            {
                return 1;
            }
            return FibNumber(cost - 1) + FibNumber(cost - 2);
        }
}