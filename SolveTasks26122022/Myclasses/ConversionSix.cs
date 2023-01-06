// //  Реализуйте класс Сonversion, сдержащий метод ToDecimalNumber, преобразующий
// // все числа 16 системы счисления в 10, метод ToBinaryNumber, преобразующий все
// // числа 16 системы счисления в 2,

// 5A = (5*16^1 + 10*8^0) = 90 пример
// abc = (a×16^2 + b×16^1 + c×16^0)

namespace Conversion16;

public class ConversionSix
{
    public int ToDecimalNumber(string number)
    {
        number = number.ToUpper();
        int result = 0;
        int helper = number.Length - 1;
        string[] massSix = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 0; j < massSix.Length; j++)
            {
                if (Convert.ToChar(number[i]) == Convert.ToChar(massSix[j]))
                {
                    result += j * Convert.ToInt32(Math.Pow(16, helper));
                    helper--;
                }
            }
        }
        return result;
    }

    public string ToBinaryNumber(string number)
    {
        string result = "";
        string[] tetrad = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        string[] massSix = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = 0; j < massSix.Length; j++)
            {
                if (Convert.ToChar(number[i]) == Convert.ToChar(massSix[j]))
                {
                    result += tetrad[j];
                }
            }
        }
        return result;
    }
}
