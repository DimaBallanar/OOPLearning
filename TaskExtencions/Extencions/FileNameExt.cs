using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskExtencions.Enums;
using static System.Net.Mime.MediaTypeNames;
//4.Написать метод расширения возвращающий имя файла из пути.
//“С:/ text / text / file - name.pdf” -> “file - name” 

namespace TaskExtencions.Extencions
{
    public static class FileNameExt
    {
        public static string FileName(this string str)
        {
            string[] array = str.Split('/');
            string result = array[array.Length - 1];
            if (!string.IsNullOrEmpty(result) && result.Contains('.'))
            {
                return $"ваше имя файла {result.Split('.')[0]}";
            }
            throw new Exception("указан путь к файлу");
        }


        //5. Написать метод расширения парсинга данных из строки вида JSON в соответствующий тип
        //данных, при неудачном преобразовании данных бросать ошибку.
        /*
        public static void JsonParse<T>(this JsonSerializer json,out T res)
        {
            if (json == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                 res = json.
            }
        }
        */

        public static T? Deserialize<T>(string json, JsonSerializerOptions options)
        {
            if (json != null)
            {
                T result = JsonSerializer.Deserialize<T>(json, options);
                return result;
            }
            throw new Exception("не удалось");
        }
        /*
                7. Написать метод расширения проверки пароля, который проверяет, чтобы строка была не
        менее 8 элементов, буквы в большом региристре, буквы в маленьком региристре, цифра, и
        один спецсимвол из списка !@#$%^&*|, другие спецсимволы не должны встречаться в
        пароле.Для каждого исключения бросать свою ошибку со своим кодом(создать
        пользовательскую ошибку и написать перечисление ошибок)
        */

        public static bool PassCheck(this string userPass)
        {
            string pattern = @"!@#$%^&*|";
            if (!string.IsNullOrEmpty(userPass))
            {
                int countB = 0;
                int countNum = 0;
                int countSymb = 0;
                foreach (char c in userPass)
                {
                    if (char.IsUpper(c)) countB++;
                    if (char.IsDigit(c)) countNum++;
                    if (Regex.IsMatch(userPass, pattern)) countSymb++;
                }
                if (countB < 1) throw new Exception("нет прописной буквы");
                if (countNum < 1) throw new Exception("нет цифр");
                if (countSymb != 1) throw new Exception("только 1 спецсимвол");
            }
            return true;
        }

    }
}




