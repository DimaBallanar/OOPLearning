using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking
{
    public class Reader
    {

        public void ChekerScript(string path, string fileChecker)
        {
            List<string> list = new List<string>();
            //Directory.GetFiles(mypath, "*.txt", SearchOption.TopDirectoryOnly).ToList().ForEach(f => Console.WriteLine(Path.GetFileName(f)));
            string[] allfiles = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string filename in allfiles)
            {
                list.Add(Path.GetFileName(filename));
                
            }
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
            public void LoaderApp(string str)
        {
            List<string> list = new List<string>();            
            string[] allfiles = Directory.GetFiles(str, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string filename in allfiles)
            {
                list.Add(Path.GetFileName(filename));
                Process.Start(filename);
            }
        }
    }
}
