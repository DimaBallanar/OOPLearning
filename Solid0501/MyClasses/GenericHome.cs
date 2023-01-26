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

    public GenericHome( T[] items)
    {
        Items=items;
    }

}