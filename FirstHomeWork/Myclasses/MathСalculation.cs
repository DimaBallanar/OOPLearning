// У вас есть класс MathСalculation. Создать в нем функцию для подсчета всех
// положительных чисел. Проверки

namespace HomeWorkFirst.Myclasses
{
    public class MathCalculation
    {
        public string numbers;
        public string[] numbersString;
        // public int summa;

        public MathCalculation()
        {
            System.Console.WriteLine("введите  любые числа через запятую");
            numbers = Convert.ToString(Console.ReadLine());
            // numbers = "10,-5,20";

        }

        public int CheckPolar()
        {
            int summa = 0;
            string[] numbersString = numbers.Split(",");
            for (int i = 0; i < numbersString.Length; i++)
            {
                int.TryParse(numbersString[i], out int num);
                if (num > 0)
                {
                    summa += num;
                }
            }
            return summa;
        }

    }
}