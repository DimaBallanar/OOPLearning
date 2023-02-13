// Создать класс Matrix. 
// Класс должен иметь следующие поля:
// двумерный массив чисел;
// количество строк и столбцов в матрице.
// Класс должен иметь следующие методы:
// сложение с другой матрицей;
// умножение на число;
// вывод на печать;
// умножение матриц.
// Значения заполняются рандомными числами. Сложение и умножение
// матриц возвращает новую матрицу.

namespace OOPTask2;

public class Matrix
{
    public int[,] Array;
    public int CountColumn;
    public int CountRow;



    public Matrix(int countColumn, int countRow)
    {
        CountColumn = countColumn;
        CountRow = countRow;
        Array = new int[CountColumn, CountRow];
    }
    public void InitMatrix()
    {
        Random rnd = new Random();
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                Array[i, j] = rnd.Next(-100, 100);
            }
        }
    }

    public void SumMatrix(Matrix fresh)
    {
        
    }
    public void Print()
    {
        for (int i = 0; i < CountRow; i++)
        {
            for (int j = 0; j < CountColumn; j++)
            {
                System.Console.Write($"{Array[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }
}