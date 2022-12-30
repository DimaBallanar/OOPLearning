using HomeWorkFirst.Myclasses;

namespace HomeWorkFirst // 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singer make = new Singer();
            // make.GetАutograph();
            // WordString use = new WordString();
            // System.Console.WriteLine(use.ReverseString());
            // System.Console.WriteLine(use.UpperFirst());
            // System.Console.WriteLine(use.UpperEvery());
            // MathCalculation collect = new MathCalculation();
            // System.Console.WriteLine(collect.CheckPolar());
            Validator validator=new Validator(Console.ReadLine());
            System.Console.WriteLine(validator.CheckEmail());
            System.Console.WriteLine(validator.IsPhone());
        }
    }
}