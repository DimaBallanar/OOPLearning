using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1302
{
    public class SvgFile:IСustomFile
    {
        private string path;
        public void Create(string name)
        {
            string path = "C:/User/" + name + ".svg";
           
            Console.WriteLine($"я создал svg файл, путь {path}");
        }

        public double GetSize()
        {
           return  DateTime.Now.Ticks/new Random().Next(1,100);
            
        }
    }
}
