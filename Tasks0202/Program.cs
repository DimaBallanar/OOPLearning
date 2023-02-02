using System;
using Tasks0202.Modules;
using System.Text.Json;



namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money dollar = new Money() { Code = 177, Name = "Dollar", Symbol = "$", LastUpdate = DateTime.Now };
            Money belRub = new Money() { Code = 667, Name = "BelRuble", Symbol = "Br" };

            Console.WriteLine(dollar.ToString());
            Console.WriteLine(belRub.ToString());

            string jsonDollar = JsonSerializer.Serialize(dollar);
            Console.WriteLine(jsonDollar);
            string jsonBelRub = JsonSerializer.Serialize(belRub);
            Console.WriteLine(jsonBelRub);
            Money newDollar = JsonSerializer.Deserialize<Money>(jsonDollar);
            Console.WriteLine(newDollar);
            Money newByn = JsonSerializer.Deserialize<Money>(jsonBelRub);
            Console.WriteLine(newByn);
            Console.WriteLine("----Custome----");
            var serializeoptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            string json = "{\"Name\":\"dollar\",\"Symbol\":\"$\"}";
            try
            {
                Money test = System.Text.Json.JsonSerializer.Deserialize<Money>(json, serializeoptions);
                Console.WriteLine(test);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            List<Money> money = new List<Money>();
            money.Add(dollar);
            money.Add(belRub);
            string testSerialize = JsonSerializer.Serialize(money);
            Console.WriteLine(testSerialize);
            var moneyTest = JsonSerializer.Deserialize<List<Money>>(testSerialize);
            moneyTest.ForEach(x => Console.WriteLine(x));


        }
    }
}