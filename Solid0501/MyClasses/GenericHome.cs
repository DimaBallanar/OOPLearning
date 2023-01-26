namespace MyClasses;

// Написать обобщенный класс (без ограничений)
// поле Items массив 
// метод добавления
// метод поиск индеса по значению
// удаления значения (по индексу, удаление по занчению)
// метод вывода 

public class GenericHome<T>
{
    private T[] Items;

    public GenericHome(T item)
    {
        T[] Items = new T[1] { default };
    }

    public void AddItem(T item)
    {
        T[] timearray = new T[++Items.Length] { };
        Array.Copy(Items, timearray, Items.Length);
        timearray[timearray.Length - 1] = item;
        Items = timearray;
    }

    public bool FindIndex(T item, out int index)
    {
        index = -1;
        for (int i = 0; i < Items.Length; i++)
        {
            if (item.Equals(Items[i]))
            {
                index = i;
                return true;
            }
        }
        return false;
    }



}