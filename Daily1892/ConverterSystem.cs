using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily1892
{
    public static class ConverterSystem
    {
        public static string ConvertBinary(this int value)
        {
            List<object> result = new List<object>();            
            object[] array = { 0, 1 };
            int binary = array.Length;
            while (value > 0)
            {
                result.Add(array[value % binary]);
                value /= binary;
            }
            result.Reverse();
            return string.Join("", result);
        }
    }
}
