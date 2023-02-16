using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Напишите программу, содержащую статический метод с тремя действительными (тип
//double) аргументами.Результатом статического метода является ссылка на метод,
//вычисляющий квадратичный трехчлен с коэффициентами, определяемыми аргументами
//статического метода. Другими словами, если статический метод вызывается с числовыми
//аргументами a, b и с, то результатом является ссылка на метод, который для аргумента x
//типа double результатом вычисляет значение выражения a*x*x+b*x+c.


namespace Work1302
{
    delegate double MethodCifr(double x);
    public class Task2
    {
        private static MethodCifr Methodica(double a, double b, double c)
        {
            MethodCifr cifr = (double x) => a * x * x + b * x + c;
            return cifr;
        }
        public void Main(double a, double b, double c)
        {
            var md=Methodica(a, b, c);
            Console.WriteLine(md(4));
            Console.WriteLine(md(0));
            Console.WriteLine(md(-6));
            Console.WriteLine(md(11));

        }

    }
}
