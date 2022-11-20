using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public class CustomListEnumerator<T> : BaseCustomListItem<T>, IEnumerator<T>
    {
        private readonly T[] _list;
        private int _position = -1;

        public CustomListEnumerator(T[] list)
        {
            _list = list;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position >= _list.Length)
                {
                    throw new InvalidOperationException();
                }

                return _list[_position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_position < _list.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
