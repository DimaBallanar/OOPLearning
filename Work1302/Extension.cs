using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1302
{
    public delegate bool Filter<T>(T item);
    public static class Extension
    {
        
        public static List<T> FilterList<T>(this List<T> data, Filter<T> method)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < data.Count; i++)
            {
                if (method(data[i]))
                {
                    list.Add(data[i]);
                }
            }
            return list;
        }

    }
}
