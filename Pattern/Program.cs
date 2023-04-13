using System;
using Pattern;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task TaskMethod(int number)
        {
            Console.WriteLine($"Method {number} starting!");
            await Task.Delay(100);
            Console.WriteLine($"Method {number} finished!");
        }
        static void Main(string[] args)
        {
            //AmericanSocket socket = new SimpleAmericanSOcket();
            //Radio radio = new Radio();
            //EuroSocket euroSocket = new SocketAdapter(socket);
            //radio.ListenMusic(euroSocket);
            
            //****************Прототип*************************
            //IAnimal animal = new PatterPrototype();
            //animal.SetName("Овечка Долли");

            //IAnimal animaclone = animal.Clone();
            //Console.WriteLine(animal.GetName());
            //Console.WriteLine(animaclone.GetName());


            //Напишите программу, которая создает 10 задач и запускает их параллельно.Каждая задача должна выводить в консоль свой порядковый номер.

            List<Task> tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskMethod(i));
            }
            Task.WaitAll(tasks.ToArray());

































            //            1.Найти все числа в массиве, которые больше 5(linq)

            //List<int> arrayNum = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var massiv=arrayNum.Where(x=>x>5);
            //foreach(var item in massiv)
            //{
            //    Console.WriteLine(item);
            //}


            //            2.Найти все строки в массиве, содержащие слово "apple“ (linq)

            //string[] strings = { "asdas", "appledsda", "adapple", "112213appl", "asdappLe" };
            //var result = strings.Where(x => x.ToLower().Contains("apple"));
            //Console.WriteLine(string.Join(",", result));



            //3.Найти количество элементов в массиве, которые равны нулю. (linq)

            //List<int> ints= new List<int>() { 1,2,3,4,0,9,0,9,0,9,0,5,5};
            //Console.WriteLine(ints.Count(x=>x==0));


            //            4.Найти первый элемент массива, который больше 10. (linq)
            //List<int> ints= new List<int>() { 1,2,3,4,0,9,11,0,9,0,9,22,0,5,5};
            //Console.WriteLine(ints.Where(x=>x>10).FirstOrDefault());

            //5.Найти среднее значение всех элементов в массиве. (linq)
            //List<int> ints= new List<int>() { 1,2,3,4,0,9,11,0,9,0,9,22,0,5,5};
            //Console.WriteLine(ints.Average());

            //6.Найти все четные числа в массиве и отсортировать их по возрастанию. (linq)
            //List<int> ints = new List<int>() { 1,55,2, 3, 4, 0, 98,9, 11, 0, 9, 0, 9, 22, 0, 5, 5 };
            //var result=ints.Where(x=>x%2==0).OrderBy(x=>x).ToList();
            //int i = 0;
            //while(i<result.Count)
            //{
            //    Console.WriteLine(result[i++].ToString());
            //}

            //7.Найти все уникальные элементы в массиве. (linq)
            //List<int> ints = new List<int>() { 1, 55, 2, 3, 4, 0, 98, 9, 11,2,4, 0, 9, 0, 9, 22, 0, 5, 5 };
            //Console.WriteLine(string.Join(",",ints.GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key)));

            //8.Найти все элементы в массиве, которые встречаются более одного раза. (linq)
            //List<int> ints = new List<int>() { 1, 55, 2, 3, 4, 0, 98, 9, 11, 2, 4, 0, 9, 0, 9, 22, 0, 5, 5 };

            //Console.WriteLine(string.Join(",", ints.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key)));

            //9.Найти наибольшее и наименьшее значение в массиве. (linq)
            //Console.WriteLine(string.Join(",", ints.Max()));
            //Console.WriteLine(string.Join(",", ints.Min()));

            //10.Найти сумму всех элементов в массиве. (linq)
            //Console.WriteLine(ints.Sum());

            //11.Объединить два массива и удалить все дубликаты. (linq)
            //List<int> ints1 = new List<int>() { 1, 55, 2, 3, 4, 0, 98,54544, 9, 11, 2, 4, 0, 9, 1022, 9, 22, 0, 5, 5 };
            //Console.WriteLine(string.Join(",",ints.Union(ints1)));

        }
    }


}