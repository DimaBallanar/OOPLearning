using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string result = array[array.Length-1];
            if (!string.IsNullOrEmpty(result)&& result.Contains('.'))
            {
                return $"ваше имя файла {result.Split('.')[0]}";
            }
            throw new Exception("указан путь к файлу");
        }
    }
}
