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

    public T AddItem(T item)
    {
        T[] timearray = new T[Items.Length + 1] { };
        Array.Copy(Items, timearray, Items.Length);


    }


}