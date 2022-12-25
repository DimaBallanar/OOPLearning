

namespace LiterSearch
{
    public class Search
    {
        char Liter;
        string Text;

        public Search(string text, char a)
        {
            Liter = a;
            Text = text;

        }

        public bool TryFind()
        {
           
            foreach (char a in Text)
            {
                if (a == Liter)
                {
                    System.Console.WriteLine("мы нашли ее");
                    return true;
                }
            }
            System.Console.WriteLine("нет такой буквы на барабане");
            return false;
        }
    }
}