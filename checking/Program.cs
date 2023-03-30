using checking;
using System;
using System.Diagnostics;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            //Reader read = new Reader();
            new Reader().Start();
            //**********************************************
            string mypath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Scripts";



        }
    }
    // НЕВЫПОЛНЕННЫЕ СОРТИРОВАТЬ
}



//string mypath = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Scripts";   //папка со скриптами    ПЕРЕПИСАТЬ ЧЕРЕЗ APPSETTINGS JSON!!!!
////       GetFiles(String path, String pattern, SearchOption options) принцип написания метода
//List<string> list = new List<string>();
////Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
//string[] allfiles = Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly); // ФАЙЛЫ SQL.
//foreach (string filename in allfiles)
//{
//    list.Add(Path.GetFileName(filename));
//    //Console.WriteLine(filename);
//}
//string fileChecker = "D:\\ДЗ С#\\hschool\\hschool_beggining_csh\\OOPLearning\\checking\\Files.txt";   //где хранится список скриптов ПЕРЕДЕЛАТЬ ЧЕРЕЗ БД(ИМЯ ВАРЧАР 255 СИМВОЛОВ)
//File.WriteAllLines(fileChecker, list);

//// запуск скриптов из файла?
////СЧИТЫВАНИЕ С КАЖДОГО ФАЙЛА ВСЕХ КОМАНД И ИХ ВЫПОЛНЕНИЕ.
////Process.Start(название файла);


////проверка новых файлов, если нет в списке, то запускаем и добавляем в список
//// метод 
//StreamReader sr = new StreamReader(fileChecker);
//string[] listec = File.ReadAllLines(fileChecker);
//foreach (string line in listec)
//{
//    if (!list.Contains(line))
//    {
//        //запуск этого скрипта к выполнению
//        //добавление названия скрипта в файл со списком скриптов Files.txt
//        File.AppendAllText(fileChecker, line);                                // открывает наш файл, добавляет в него строку

//    }

//        }
