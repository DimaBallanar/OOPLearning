// Реализуйте класс Sort, сдержащий метод SortData, сортирующий все числа
// статичного массива сортировкой пузырьком

namespace SortPuzir;

public class Sort
{

    public void SortData(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
                if (array[j] > array[j + 1])
                {
                    int timeNum = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = timeNum;
                }
        }
        System.Console.WriteLine(string.Join(",", array));

    }
}