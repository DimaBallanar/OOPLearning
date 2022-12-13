// Реализуйте класс WordString, который будет иметь следующие методы: метод
// ReverseString(), переворачивающий строку, метод UpperFirst(), возвращающий
// строку, где первая буква заглавная и метод UpperEvery(), который делает
// заглавной первую букву каждого слова этой строки.
namespace HomeWorkFirst.Myclasses
{
    public class WordString
    {
        public string? text;

        public WordString()
        {
            System.Console.WriteLine("введите строку");
            text = Convert.ToString(Console.ReadLine());
        }
        public string ReverseString()
        {
            string timeText="";
            for(int i=text.Length-1;i>-1;i--)
            {
timeText+=text[i];
            }
            return timeText;
        }
    }
}