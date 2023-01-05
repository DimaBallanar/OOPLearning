// 9. Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// все числа 2 системы счисления в 10, метод ToHexadecimalNumber, преобразующий
// все числа 2 системы счисления в 16, метод ToOctalNumber, преобразующий все
// числа 2 системы счисления в 8

using Conversion10;
namespace Conversion2;

public class ConversionTwo
{

    public int ToDecimalNumber(string number)
    {
        int result = 0;
        int helper = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int cifra = number[i] - 48;
            result += cifra * Convert.ToInt32(Math.Pow(2, helper));
            helper++;
        }
        return result;
    }

    public string ToOctalNumber(string number) //11 001 010
    {

        string result = Convert.ToString(ToDecimalNumber(number));
        Conversion op = new Conversion();
        result = op.ToOctalNumber(Convert.ToInt32(result));

        // for (int i = number.Length - 2; i >= 3; i=i-3)
        // {
        //     result+=number[i-1]+number[i]+number[i+1];
        // }
        return result;
    }
    public string ToHexadecimalNumber(string number) //11 001 010
    {

        string result = Convert.ToString(ToDecimalNumber(number));
        Conversion op = new Conversion();
        result = op.ToHexadecimalNumber(Convert.ToInt32(result));        
        return result;
    }

}