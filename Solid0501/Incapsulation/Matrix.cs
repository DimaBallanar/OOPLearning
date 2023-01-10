// Преобразовать строки двумерного массива в столбцы. Класс будет содержать два 
// метода: один заполнит массив значениями, второй произведет замену значений 
// строк на значения столбцов.

namespace Incapsulation;

public class Matrix
{
    private int Column;
    private int Row;
    private int[,] Field;

    public Matrix(int column, int row)
    {
        Column = column;
        Row = row;
        Field = new int[Row, Column];
    }

    public void SetData()
    {
        Random rnd = new Random();
        for (int i = 0; i < Row; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                Field[i, j] = rnd.Next(0, 100);
                System.Console.Write($"{Field[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }

    public void ChangeData()
    {
        int[,] timeMat = new int[Column, Row];
        for (int i = 0; i < Column; i++)
        {
            for (int j = 0; j < Row; j++)
            {
                timeMat[i, j] = Field[j, i];
                System.Console.Write($"{timeMat[i, j]} ");
            }
            System.Console.WriteLine();
        }
        Field = timeMat;
        
    }

}
