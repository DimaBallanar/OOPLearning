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
           
            object[] array = { 0, 1 };

            return Converter(value, array);
        }

        public static string ConvertOctal(this int value)
        {
           
            object[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };

            return Converter(value, array);
        }
        public static string ConvertDec(this int value)
        {
            
            object[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
           
            return Converter(value,array);
        }

        private static string Converter( long value,object[] array)
        {
            List<object> result = new List<object>();           
            int baseSys = array.Length;
            while (value > 0)
            {
                result.Add(array[value % baseSys]);
                value /= baseSys;
            }
            result.Reverse();
            return string.Join("", result);
        }
    }
}
