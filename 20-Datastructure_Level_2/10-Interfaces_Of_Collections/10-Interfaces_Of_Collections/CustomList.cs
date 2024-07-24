using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Of_Collections
{
    public class CustomList<T> : IList<T>
    {
        private List<T> _items = new List<T>();

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }


        public int Count => _items.Count;
        public bool IsReadOnly => false;


        public void Add(T item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public bool Contains(T item) => _items.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        public int IndexOf(T item) => _items.IndexOf(item);
        public void Insert(int index, T item) => _items.Insert(index, item);
        public bool Remove(T item) => _items.Remove(item);
        public void RemoveAt(int index) => _items.RemoveAt(index);


        IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public int CompareTo(Person other)
        {
            if (other == null) return 1;

            return this.Age.CompareTo(other.Age);
        }
    }
}
