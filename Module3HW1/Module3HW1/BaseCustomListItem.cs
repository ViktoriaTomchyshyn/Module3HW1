using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW1
{
    public abstract class BaseCustomListItem<T> : IComparable<T>
    {
        public int CompareTo(T other)
        {
            if (other == null)
            {
                return 1;
            }
            else
            {
                return ToString().CompareTo(other.ToString());
            }
        }
    }
}
