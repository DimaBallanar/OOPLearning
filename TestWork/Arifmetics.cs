using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestWork
{
    public class Arifmetics
    {
        //        Напишите программу, которая вычисляет сумму двух чисел, введенных
        //пользователем.
        public double Sum(string x, string y)
        {
            if (double.TryParse(x, out double resultX) && double.TryParse(y, out double resultY))
            {
                return resultX + resultY;
            }
            return 0;
        }
        //        Напишите программу, которая определяет, является ли введенное число четным
        //или нечетным
        public bool Chetnoe(string x)
        {
            double.TryParse(x, out double resultX);
            if (resultX % 2 == 0)
            {
                return true;
            }
            return false;
        }
        //        Напишите программу, которая находит среднее арифметическое двух чисел,
        //введенных пользователем.

        public double SrAr(string x, string y)
        {
            double.TryParse(x, out double resultX);
            double.TryParse(y, out double resultY);
            return (resultX + resultY) / 2;
        }

        //        4. Напишите программу, которая запрашивает у пользователя длину и ширину
        //прямоугольника, а затем выводит его площадь.

        public double Square()
        {
            Console.Write("Введите длину прямоугольника: ");
            double.TryParse(Console.ReadLine(), out double resultX);
            Console.Write("Введите ширину прямоугольника: ");
            double.TryParse(Console.ReadLine(), out double resultY);
            Console.Write("Площадь прямоугольника равна ");
            return resultX * resultY;
        }

        //        Напишите программу, которая проверяет, является ли введенная строка
        //палиндромом(слово или фраза, которые читаются одинаково слева направо и
        //справа налево).

        public string Palindrom()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            //string[] temp = text.ToCharArray();
            if (text.ToLower() == string.Join("", text.Split("").Reverse()).ToLower())
            {
                return $"{text} - палиндром";
            }
            return $"{text} - не палиндром";
        }

        //        Напишите программу, которая запрашивает у пользователя три числа и выводит
        //на экран наименьшее из них.

        public string Max()
        {
            Console.Write("введите число а: ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("введите число b: ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.Write("введите число c: ");
            double.TryParse(Console.ReadLine(), out double c);
            if (Math.Max(a, b) > c)
            {
                return $"{Math.Max(a, b)}";
            }
            return $"{c}";
        }

        //        7. Напишите программу, которая запрашивает у пользователя строку и выводит на
        //экран количество гласных букв в этой строке.
        public int NumGlas()
        {
            Console.Write("ВВедите текст: ");
            string text = Console.ReadLine();
            string glasnie = "аиеёоуыэюяАИЕЁОУЫЭЮЯ";
            int num = 0;
            foreach (char c in text)
            {
                if (glasnie.Contains(c))
                {
                    num++;
                }
            }
            return num;
        }

        //        8. Напишите программу, которая запрашивает у пользователя год рождения и
        //выводит его возраст на текущую дату.
        public int Age()
        {
            Console.Write("Введите год своего рождения: ");
            int.TryParse(Console.ReadLine(), out int x);
            return DateTime.Now.Year - x;
        }

        //        9. Напишите программу, которая запрашивает у пользователя два числа и находит
        //их наибольший общий делитель

        public int NOD()
        {
            Console.Write("введите число а: ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("введите число b: ");
            int.TryParse(Console.ReadLine(), out int b);
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        //        10. Напишите программу, которая генерирует случайное число от 1 до 100 и
        //предлагает пользователю угадать это число, давая подсказки(больше/меньше),
        //если введенное число не совпадает с загаданным.

        public void FindNumber()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 100);
            Console.WriteLine(x);
            while (true)
            {
                Console.Write("введите загаданное число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == x)
                {
                    Console.WriteLine("вы угадали!");
                    break;
                }
                else if (number > x)
                {
                    Console.WriteLine("загаданное число меньше");
                }
                else
                {
                    Console.WriteLine("загаданное число больше");
                }
            }
        }

        //        11. Напишите программу, которая находит все простые числа от 2 до N, где N - число,
        //введенное пользователем.

        public string FindProst()
        {
            Console.Write("ВВедите число от 2 до бесконечности: ");
            int.TryParse(Console.ReadLine(), out int number);
            string result = "";
            for (int i = 2; i <= number; i++)
            {
                int counter = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    result += i + ",";
                }
            }
            return result;
        }

        //        12. Напишите программу, которая находит наибольшую возрастающую
        //последовательность в массиве целых чисел.

        public string Posled(int[] massiv)  // доделать
        {
            string result = "";
            string temp = "";
            for (int i = 1; i < massiv.Length; i++)
            {
                if (massiv[i] > massiv[i - 1])
                {
                    temp += massiv[i - 1] + ",";
                }               
             
                else if (massiv[i] <= massiv[i-1] && temp.Length>result.Length)
                {
                    result = temp;
                    temp ="";
                }
            }
            return result;
            //string[] charge = result.Split(" ");
            //string finish = "";
            //for (int i = 0; i < charge.Length - 1; i++)
            //{
            //    if (charge.Length == 1)
            //    {
            //        finish = charge[i];
            //        continue;
            //    }
            //    else if (charge[i].Length > charge[i + 1].Length)
            //    {
            //        finish = charge[i];
            //    }

            //}


        }

        //        13. Напишите программу, которая реализует алгоритм сортировки слиянием для
        //массива целых чисел.



        //        14. Напишите программу, которая находит наименьшее количество монет,                                 ******** **** бесконечный цикл 
        //необходимых для выдачи сдачи пользователю при покупке товара.У вас есть
        //монеты номиналом 1, 5, 10, 25 и 50 центов.
        public void Sdacha()
        {
            Console.Write("на какую сумму взял товара покупатель? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("на какую сумму взял товара покупатель? ");
            double moneyUser = Convert.ToDouble(Console.ReadLine());
            int[] coins = { 50, 25, 10, 5, 1 };
            int result = Convert.ToInt32((moneyUser - price) * 100);
            List<int> list = new List<int>();
            for (int i = 0; i < coins.Length; i++)
            {
                while (result % coins[i] == 0)
                {
                    list.Add(coins[i]);
                    result-= coins[i];
                }
            }
            var array = list.GroupBy(list => list);
            foreach(var ar in array)
            {
                Console.WriteLine($"{ar.Key} надо {ar.Count()}");
            }


        }

        //        15. Напишите программу, которая реализует алгоритм поиска в ширину для графа,
        //представленного в виде списка смежности.


        //        16. Напишите программу, которая реализует алгоритм быстрой сортировки для
        //массива целых чисел.

        //        17. Напишите программу, которая реализует алгоритм бинарного поиска для
        //отсортированного массива целых чисел.

        //18. Напишите программу, которая выводит заданную строку задом наперед.

        public string ReverseString()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            string[] result = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string check = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                check += result[i] + " ";
            }
            return check;

        }

        //        19. Напишите программу, которая определяет, является ли заданная строка
        //палиндромом.
        public string PalindromString()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            string[] result = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string check = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                check += result[i] + " ";
            }
            if (text.Trim() == check.Trim())
            {
                return "палиндром";
            }
            return "не палиндром";

        }

        //        20.Напишите программу, которая удаляет все пробелы из заданной строки.
        public string DeleteProbel()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            string[] result = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return string.Join(' ', result);
        }

        //21. Напишите программу, которая заменяет все пробелы в заданной строке
        //символом подчеркивания.
        public string ChangeTrim()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            string result = "";
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    result += '_';
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        //22. Напишите программу, которая находит количество гласных букв в заданной
        //строке.
        public int CountGlas()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            int count = 0;
            string glas = "ёуеыаоэяию";
            foreach (char c in glas)
            {
                count += Regex.Matches(text.ToLower(), c.ToString()).Count();
            }
            return count;
        }


        //23. Напишите программу, которая находит количество слов в заданной строке.
        public int CountWords()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            int count = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count();
            return count;
        }

        //24.Напишите программу, которая находит длину самого длинного слова в заданной
        //строке.
        public int LongWord()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            string[] array = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<int> ints = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                ints.Add(array[i].Length);
            }
            return ints.Max();
        }


        //25. Напишите программу, которая проверяет, является ли заданная строка числом.

        public bool CheckInt()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            if (int.TryParse(text, out int x))
            {
                return true;
            }
            return false;
        }



        //26. Напишите программу, которая находит индекс первого вхождения заданного
        //символа в строке.
        public int FirstIndex()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            Console.Write("введите символ для поиска: ");
            char a = Convert.ToChar(Console.ReadLine());
            return text.ToLower().IndexOf(a);
        }


        //27. Напишите программу, которая находит наиболее часто встречающийся символ в                     
        //заданной строке.
        public void IndexCount()
        {
            Console.Write("введите текст: ");
            string text = Console.ReadLine();
            Dictionary<char, int> values = new Dictionary<char, int>();
            char x;
            for (int i = 0; i < text.Length; i++)
            {
                x = text[i];
                int count;
                if (x != ' ')
                {
                    count = Regex.Matches(text.ToLower(), x.ToString()).Count();
                    values.Add(x, count);
                }
                text = text.Replace(x, ' ');
            }
            int counter = 0;
            var temp = values;
            foreach (var t in values)
            {
                if (t.Value > counter)
                { counter = t.Key; }

            }
            foreach (var t in temp)
            {
                if (t.Value == counter)
                {
                    Console.WriteLine($"{t.Key}");
                }
            }
        }


        //28.Напишите программу, которая находит максимальный элемент в списке чисел.

        public int MaxValueNum()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"введите {i} число: ");
                int.TryParse(Console.ReadLine(), out int number);
                lists.Add(number);
            }
            return lists.Max();

        }

        //29. Напишите программу, которая находит сумму всех элементов в списке чисел.

        public double SumArrayNum()
        {
            Console.Write("Введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int number);
            double counter = 0;
            for (int i = 0; i < number; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                counter += x;
            }
            return counter;
        }

        //30.Напишите программу, которая удаляет все дубликаты из списка.

        public void DeleteDublicat()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            IEnumerable<string> distinctItems = lists.Distinct();
            foreach (string items in distinctItems)
            {
                Console.WriteLine(items);
            }
        }

        //31. Напишите программу, которая находит все уникальные элементы в списке.
        public void SearchUnique()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            List<string> newList = new List<string>();

            foreach (string items in lists)
            {
                if (lists.IndexOf(items) == lists.LastIndexOf(items))
                {
                    newList.Add(items);
                }
            }
            foreach (string j in newList)
            {
                Console.WriteLine(j);
            }
        }


        //32. Напишите программу, которая находит среднее арифметическое всех элементов
        //в списке чисел.

        public double SrArifmetic()
        {
            Console.Write("Введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int number);
            double counter = 0;
            for (int i = 0; i < number; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                counter += x;
            }
            return counter / number;
        }


        //33. Напишите программу, которая сортирует список чисел по возрастанию.
        public void SortList()
        {
            Console.Write("Введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int number);
            List<int> lists = new List<int>();
            for (int i = 0; i < number; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int numberLine);
                lists.Add(numberLine);
            }
            lists.Sort();
            foreach (int item in lists)
            {
                Console.WriteLine(item);
            }
        }


        //34.Напишите программу, которая находит наиболее часто встречающийся элемент в
        //списке.
        public void SearchMaxCheck()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            string myDear = "";
            int count = 0;
            var temp = lists.GroupBy(e => e);
            foreach (var t in temp)
            {
                if (t.Count() > count)
                { count = t.Count(); }

            }
            foreach (var t in temp)
            {
                if (t.Count() == count)
                {
                    Console.WriteLine($"{t.Key}");
                }
            }

        }

        //35. Напишите программу, которая объединяет два списка в один.                                          
        public void MergeNum()
        {
            Console.Write("введите количество элементов первого массива: ");
            int.TryParse(Console.ReadLine(), out int num1);
            List<string> lists1 = new List<string>();
            for (int i = 0; i < num1; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists1.Add(Console.ReadLine());
            }
            Console.Write("введите количество элементов второго массива: ");
            int.TryParse(Console.ReadLine(), out int num2);
            List<string> lists2 = new List<string>();
            for (int i = 0; i < num2; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists2.Add(Console.ReadLine());
            }
            lists1.AddRange(lists2);
            foreach (string t in lists1)
            {
                Console.WriteLine(t);
            }
        }


        //36. Напишите программу, которая находит элемент, находящийся на заданной
        //позиции в списке.
        public string TakeElement()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            Console.Write("какой элемент массива вы хотите вернуть? ");
            int.TryParse(Console.ReadLine(), out int numberLine);
            if (numberLine <= lists.Count)
            {
                return lists[numberLine];
            }
            return "ошибка ввода";
        }

        //37. Напишите программу, которая находит все элементы, удовлетворяющие
        //заданному условию в списке.

        public void SearchElem()

        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }

        }


        //38.Напишите запрос, который находит все строки в заданном массиве строк,
        //содержащие заданную подстроку. (linq)
        public void SearchElem1()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            Console.WriteLine("введите подстроку:");
            string kusok = Console.ReadLine();
            foreach (string list in lists)
            {
                if (list.Contains(kusok))
                {
                    Console.WriteLine(list);
                }
            }
        }

        //39. Напишите запрос, который находит все числа в заданном массиве чисел,
        //большие заданного значения. (linq)
        public void SearchElemNum()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            Console.WriteLine("введите подстроку:");
            int kusok = Convert.ToInt32(Console.ReadLine());
            foreach (int list in lists)
            {
                if (list > kusok)
                {
                    Console.WriteLine(list);
                }
            }
        }

        //40.Напишите запрос, который находит все строки в заданном массиве строк, длина
        //которых больше заданного значения. (linq)
        public void SearchElem2()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            Console.WriteLine("введите длину строки:");
            int kusokLength = Convert.ToInt32(Console.ReadLine());
            List<string> newList = lists.FindAll(p => p.Length >= kusokLength);
            foreach (string list in newList)
            {
                Console.WriteLine(list);
            }
        }

        //41. Напишите запрос, который находит сумму всех чисел в заданном массиве чисел.
        //(linq)
        public int SumDiapazone()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            Console.WriteLine("введите начальный индекс:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите конечный индекс:");
            int end = Convert.ToInt32(Console.ReadLine());
            var range = lists.GetRange(start, end);
            return range.Sum();
        }

        //42.Напишите запрос, который находит среднее арифметическое всех чисел в
        //заданном массиве чисел. (linq)
        public int ArifmeticRange()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            Console.WriteLine("введите начальный индекс:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите конечный индекс:");
            int end = Convert.ToInt32(Console.ReadLine());
            var range = lists.GetRange(start, end);
            return range.Sum() / range.Count;
        }

        //43.Напишите запрос, который находит максимальный элемент в заданном массиве
        //чисел. (linq)
        public int MaxListEle()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            return lists.Max();
        }

        //44.Напишите запрос, который находит все элементы в заданном массиве чисел,
        //удовлетворяющие заданному условию. (linq)
        public void FindRangeIndex()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            Console.WriteLine("введите начальный индекс:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите конечный индекс:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значение:");
            int check = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите знак:");
            //string znak = Console.ReadLine();
            var range = lists.FindAll(p => p > check);
            foreach (var a in range)
            {
                Console.WriteLine(a);
            }
        }

        //45.Напишите запрос, который находит первый элемент в заданном массиве чисел,
        //удовлетворяющий заданному условию. (linq)
        public void FindFirstNum()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<int> lists = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                int.TryParse(Console.ReadLine(), out int x);
                lists.Add(x);
            }
            Console.WriteLine("введите значение:");
            int check = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите знак:");
            string znak = Console.ReadLine();
            if (znak == ">")
            {
                var range = lists.Find(p => p > check);
                Console.WriteLine(range);
            }
            else if (znak == "<")
            {
                var range = lists.Find(p => p < check);
                Console.WriteLine(range);
            }
        }

        //46.Напишите запрос, который находит количество элементов в заданном массиве
        //строк, начинающихся с заданной буквы. (linq)
        public void FindEleString()

        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            Console.WriteLine("введите букву:");
            char liter = Convert.ToChar(Console.ReadLine());
            List<string> newList = lists.FindAll(p => p.Trim().StartsWith(liter));
            Console.WriteLine($"количество элементов = {newList.Count}");
        }
        //47.Напишите запрос, который находит наиболее часто встречающийся элемент в
        //заданном массиве. (linq)
        public void FindEveryItem()
        {
            Console.Write("введите количество элементов: ");
            int.TryParse(Console.ReadLine(), out int num);
            List<string> lists = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write($"задайте {i} значение: ");
                lists.Add(Console.ReadLine());
            }
            string elem = "";
            int count = 0;
            foreach (string item in lists)
            {
                if (count < lists.FindAll(p => p == item).Count)
                {
                    count = lists.FindAll(p => p == item).Count;
                    elem = item;
                }
            }
            Console.WriteLine(elem);
        }




        //49.Создайте класс для работы с геометрическими фигурами, включающий методы
        //расчета периметра и площади фигуры.Реализуйте интерфейс IShape для всех
        //фигур.


        //50.Создайте класс для работы с квадратными матрицами, включающий методы для
        //сложения, вычитания и умножения матриц. Реализуйте интерфейс IMatrix для
        //матриц.


        //51. Создайте класс для работы с банковскими счетами, включающий методы для
        //внесения и снятия денег со счета.Реализуйте интерфейс IAccount для счетов.


        //52. Создайте класс для работы с датами, включающий методы для вычисления дня
        //недели и расчета разницы между двумя датами. Реализуйте интерфейс IDate для
        //работы с датами.


        //53. Создайте класс для работы с координатами, включающий методы для расчета
        //расстояния между двумя точками и определения направления движения.
        //Реализуйте интерфейс ICoordinate для координат.



    }
}
