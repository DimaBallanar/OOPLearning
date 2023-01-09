// Напишите класс ShiftSupervisor (Начальник смены),
// который является подклассом класса Ernployee, созданного в задаче по
// программированию 1. Класс ShiftSupervisor должен содержать атрибут данных для
// годового оклада и атрибут данных для годовой производственной премии,
// которую заработал начальник смены. Продемонстрируйте класс, написав
// программу, которая применяет объект ShiftSupervisor. 
using Myclasses.Employee;


public class ShiftSupervisor : Employee
{
    public double Oklad;
    public double Premiya;
    public ShiftSupervisor()
    {

    }

    public ShiftSupervisor(string name, int number, double oklad, double premiya) : base(name, number)
    {
        Oklad = Okla() * 12;
        Premiya = Prem();
    }

    public double Okla()
    {
        System.Console.Write("введите месячный оклад: ");
        double oklad = Convert.ToDouble(Console.ReadLine());
        return oklad;
    }

    public double Prem()
    {
        System.Console.Write("введите премию: ");
        double prem = Convert.ToDouble(Console.ReadLine());
        return prem;
    }

}