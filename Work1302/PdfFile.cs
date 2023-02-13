using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1302
{
    internal class PDFFile : ICustomFile
    {
        string path;
        public void Create(string name)
        {
            path = "C:/User/" + name + ".doc";
            Console.WriteLine($"я создал doc файл, путь {path}");
        }

        public double GetSize()
        {
            Random rnd = new Random();
            double size = rnd.Next(1, 1000000);
            return size / path.Length;
        }
    }
}
