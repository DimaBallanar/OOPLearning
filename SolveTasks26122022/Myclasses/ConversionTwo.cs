// 9. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 2 системы счисления в 10, метод ToHexadecimalNumber, преобразующий
// все числа 2 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 2 системы счисления в 8

namespace Conversion2;

public class ConversionTwo
{

    public int ToDecimalNumber(string number)
    {
        int result = 0;
        int helper = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int cifra = number[i]-48;
            result += cifra * Convert.ToInt32(Math.Pow(2, helper));
            helper++;
        }
        return result;
    }
}