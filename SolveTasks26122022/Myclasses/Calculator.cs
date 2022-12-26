

namespace NewCalculator;

public class Calculator
{
    public int DoPlus(params int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    public int DoMinus(params int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result -= array[i];
        }
        return result;
    }

    public int DoMultiply(params int[] array)
    {
        int result = 1;
        int i = 0;
        while (i < array.Length)
        {
            result *= array[i++];

        }
        return result;
    }

    public int DoDivide(params int[] array)
    {
        int result = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            result /= array[i];
        }
        return result;
    }
}