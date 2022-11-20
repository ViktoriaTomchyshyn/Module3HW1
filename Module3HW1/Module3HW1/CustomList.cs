using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Module3HW1
{
    public class CustomList<T> : BaseCustomListItem<T>, IEnumerable
        where T : IComparable<T>
    {
        private T[] _list;

        public CustomList()
        {
            _list = null;
        }

        public CustomList(T[] list)
        {
            _list = list;
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListEnumerator<T>(_list);
        }

        public void Add(T item)
        {
            if (_list == null)
            {
                _list = new T[1] { item };
            }
            else
            {
                Array.Resize<T>(ref _list, _list.Length + 1);
                _list[_list.Length - 1] = item;
            }
        }

        public void AddRange(T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public void AddRange(List<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            if (_list != null && Array.IndexOf(_list, item) > -1)
            {
                int index = Array.IndexOf(_list, item);
                bool res = RemoveAt(index);
                return res;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveAt(int index)
        {
            if (index > -1 && index < _list.Length - 1)
            {
                List<T> tmp = new List<T>(_list);
                tmp.RemoveAt(index);
                _list = tmp.ToArray();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<T> Sort()
        {
            T temp;
            for (int j = 0; j <= _list.Length - 2; j++)
            {
                for (int i = 0; i <= _list.Length - 2; i++)
                {
                    if (_list[i].CompareTo(_list[i + 1]) > 0)
                    {
                        temp = _list[i + 1];
                        _list[i + 1] = _list[i];
                        _list[i] = temp;
                    }
                }
            }

            foreach (T item in _list)
            {
                yield return item;
            }
        }

        public override string ToString()
        {
            string res = string.Empty;

            foreach (T item in _list)
            {
                res += item + " ";
            }

            return res;
        }
    }
}
