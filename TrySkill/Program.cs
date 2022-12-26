using LiterSearch;

namespace Game;

internal class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("введите текст");
        string? text = Console.ReadLine();
        System.Console.Write("какую букву ищем?");
        char lite = Console.ReadKey().KeyChar;
        Search literSearch = new Search(text, lite);
        literSearch.TryFind();

    }
}

