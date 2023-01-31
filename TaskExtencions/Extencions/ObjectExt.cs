using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExtencions.Extencions
{
   public static class ObjectExt
    {
        public static bool TryToConvert<T>(this object obj, out T result)
        {
            if (obj is T temp) 
            { result = temp;
                return true;
            }
            result = default;
            return false;
        }
    }
}
