// Реализуйте класс Сonversion, сдержащий метод ToBinaryNumber, преобразующий
// все числа 10 системы счисления в 2, метод ToHexadecimalNumber, преобразующий
// все числа 10 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 10 системы счисления в 8

namespace Conversion10;

public class Conversion
{
    
    public string ToBinaryNumber(int number)
    {
        if (number == 0)
        {
            return "0";
        }
        string text = "";
        while (number > 0)
        {
            text += number % 2;
            number = number / 2;
        }
        return Reverse(text);
    }
    public string ToHexadecimalNumber(int number)
    {
        string text = "";
        if (number == 0)
        {
            return "0";
        }
        while (number > 0)
        {
            int op = number % 16;
            text += op switch
            {
                1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                8 => 8,
                9 => 9,
                10 => "A",
                11 => "B",
                12 => "C",
                13 => "D",
                14 => "E",
                15 => "F",
                _ => 0
            };

            number = number / 16;
        }

        return Reverse(text);
    }
    public string ToOctalNumber(int number)
    {
        string text = "";
        if (number == 0)
        {
            return "0";
        }
        while (number > 0)
        {
            int op = number % 8;
            text += op switch
            {
                1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                5 => 5,
                6 => 6,
                7 => 7,
                _ => 0
            };

            number = number / 8;
        }
        return Reverse(text);
    }
    private string Reverse(string text)
    {
        string output = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            output += text[i];
        }
        return output;
    }

}