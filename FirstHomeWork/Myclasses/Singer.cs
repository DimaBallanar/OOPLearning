namespace HomeWorkFirst.Myclasses
{
    public class Singer
    {
        public string? name;
        public string? surname;
        public Singer()
        {
            System.Console.WriteLine("введите своё имя");
            name = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("введите свою фамилию");
            surname = Convert.ToString(Console.ReadLine());

        }
        public void GetАutograph()
        {
            System.Console.WriteLine($"{name} {surname}, c наилучшими пожеланиями");
        }
    }
}