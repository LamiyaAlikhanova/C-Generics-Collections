using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task105_L.A._7
{
    internal class CustomGenericList<T>
    {
        T[] array; 
        public CustomGenericList() 
        {
            array=Array.Empty<T>();

        }
        public void Add(T item)
        {
            Array.Resize(ref array, array.Length+1);
            array[^1] = item;
        }
        public T? Find (Predicate<T> match)
        {
            foreach (var item in array) 
            {
                if (match(item)) 
                {
                    return item;
                }
            }
            return default(T);
        } 
        public List<T> FindAll(Predicate<T>match)
        {
            List<T> resultlist = new List<T>();
            for (int i=0; i<array.Length; i++)
            {
                if (match(array[i]))
                {
                    resultlist.Add(array[i]);
                }
                 
            }
            return resultlist;
        }
        public bool Remove (T item)
        {
            for (int i=0, i<array.Length; i++)
            {
                if (array[i].Equals(array))
                {

                }
            }
        }

        
    }
}
