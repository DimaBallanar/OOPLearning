using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String mypath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Scripts";   //папка со скриптами
            //       GetFiles(String path, String pattern, SearchOption options) принцип написания метода
            List<string> list = new List<string>();
            //Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
            string[] allfiles = Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string filename in allfiles)
            {
                list.Add(Path.GetFileName(filename));
                //Console.WriteLine(filename);
            }
            string fileChecker = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Files.txt";   //где хранится список скриптов
            File.WriteAllLines(fileChecker, list);

            // запуск скриптов из файла?

            //проверка новых файлов, если нет в списке, то запускаем и добавляем в список
            // метод 
            StreamReader sr = new StreamReader(fileChecker);
            string[] listec = File.ReadAllLines(fileChecker);
            foreach (string line in listec)
            {
                if (!list.Contains(line))
                {
                    //запуск этого скрипта к выполнению
                    //добавление названия скрипта в файл со списком скриптов Files.txt
                    File.AppendAllText(fileChecker, line);                                // открывает наш файл, добавляет в него строку

                }

                    }

        }
    }

}



