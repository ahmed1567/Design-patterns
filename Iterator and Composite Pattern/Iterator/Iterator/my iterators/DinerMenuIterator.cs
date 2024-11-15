using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Iterator
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int Position = 0;
        public DinerMenuIterator(MenuItem[] _items)
        {
            items = _items;
        }
        public object Current() {
            MenuItem menuItem = items[Position];
            Position = Position + 1;
            return menuItem;
        }


        public bool MoveNext()
        {
            if (Position >= items.Length || items[Position] == null) {
            return false;
            }
            else
            {
                return true;
            }
        }

 
    }
}
