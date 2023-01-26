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

    public GenericHome()
    {
        T[] Items = new T[] { };
    }

    public void  AddItem(T item)
    {
        T[] timearray = new T[Items.Length + 1] { };
        Array.Copy(Items, timearray, Items.Length);
        timearray[timearray.Length - 1] = item;
        Items = timearray;
    }
    


}