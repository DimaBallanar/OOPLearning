using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskExtencions.Enums;

namespace TaskExtencions.Extencions
{
    public static class FileExtencion
    {
        public static string FileTypeMessage(this FileTypes xxx)
        {
            if(Enum.IsDefined(xxx))
            {
                return $"Выбран файл с расширением .{xxx}";
            }
            throw new Exception("нет в наличии");
        }
    }
}
