using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Of_Collections
{
    public class CustomCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();


        public int Count => items.Count;


        public bool IsReadOnly => false;


        public void Add(T item)
            {
                items.Add(item);
            }


        public void Clear()
            {
                items.Clear();
            }


        public bool Contains(T item)
            {
                return items.Contains(item);
            }


        public void CopyTo(T[] array, int arrayIndex)
            {
                items.CopyTo(array, arrayIndex);
            }


        public bool Remove(T item)
            {
                return items.Remove(item);
            }


        public IEnumerator<T> GetEnumerator()
            {
                return items.GetEnumerator();
            }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
