using System.Collections;

namespace Iterator
{
    public class PancakeHouseMenuIterator : Iterator
    {
        List<MenuItem> menuItems;
        int Position = 0;

         public object Current()
        {
            MenuItem item = menuItems[Position];
            Position++;
            return item;
        }


        public PancakeHouseMenuIterator(List<MenuItem> _items)
        {
            menuItems = _items;
        }
        public bool MoveNext()
        {
            if (Position >= menuItems.Count || menuItems[Position] == null)
            {
                return false;
                
            }
            else
            {
                return true;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new PancakeHouseMenuIterator(menuItems).GetEnumerator();
        }
    }
}