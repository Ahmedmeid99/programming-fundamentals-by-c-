using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces_Of_Collections
{
    public class CustomDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _list = new List<KeyValuePair<TKey, TValue>>();


        public TValue this[TKey key]
        {
            get
            {
                foreach (var kvp in _list)
                {
                    if (Equals(kvp.Key, key))
                    {
                        return kvp.Value;
                    }
                }
                throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
            }
            set
            {
                bool found = false;
                for (int i = 0; i < _list.Count; i++)
                {
                    if (Equals(_list[i].Key, key))
                    {
                        _list[i] = new KeyValuePair<TKey, TValue>(key, value);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    _list.Add(new KeyValuePair<TKey, TValue>(key, value));
                }
            }
        }


        public ICollection<TKey> Keys => _list.ConvertAll(kvp => kvp.Key);


        public ICollection<TValue> Values => _list.ConvertAll(kvp => kvp.Value);


        public int Count => _list.Count;


        public bool IsReadOnly => false;


        public void Add(TKey key, TValue value)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    throw new ArgumentException("An element with the same key already exists.");
                }
            }
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }


        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }


        public void Clear()
        {
            _list.Clear();
        }


        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _list.Contains(item);
        }


        public bool ContainsKey(TKey key)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    return true;
                }
            }
            return false;
        }


        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }


        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return _list.GetEnumerator();
        }


        public bool Remove(TKey key)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (Equals(_list[i].Key, key))
                {
                    _list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return _list.Remove(item);
        }


        public bool TryGetValue(TKey key, out TValue value)
        {
            foreach (var kvp in _list)
            {
                if (Equals(kvp.Key, key))
                {
                    value = kvp.Value;
                    return true;
                }
            }
            value = default;
            return false;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
