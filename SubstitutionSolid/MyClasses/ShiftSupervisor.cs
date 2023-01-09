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

    public ShiftSupervisor(string name, int number, double oklad, double premiya) : base(name, number)
    {
        Oklad = oklad * 12;
        Premiya = premiya;
    }

}