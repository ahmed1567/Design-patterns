using System.Drawing;

namespace Iterator
{
    public class DinerMenu :Imenu
    {
        MenuItem[] menuItems;
        int MAX_ITEMS = 6;
        

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            menuItems[0]=new MenuItem("Hotdog","A hot dog, with saurkraut, relish, onions, topped with cheese",false, 3.05);
            menuItems[1]= new MenuItem("Soup of the day","Soup of the day, with a side of potato salad", false, 3.29);
            menuItems[2]=new MenuItem("BLT","Bacon with lettuce & tomato on whole wheat", false, 2.99);
            menuItems[3]=new MenuItem("Vegetarian BLT","(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
        }
       

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Append(menuItem);
        }
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public IEnumerator<MenuItem> createIteratorV2()
        {
            //when you use an array with IEnumerator, if you don’t specify the type, you get a non-generic IEnumerator, which means its Current property is of type object. To access the specific type, you would need to cast Current to the appropriate type.
            IEnumerator<MenuItem> enumerator = menuItems.Cast<MenuItem>().GetEnumerator();
            //you cannot directly cast the enumerator returned by an array to a generic IEnumerator<T> because arrays return a non-generic IEnumerator by default. To create a generic IEnumerator<MenuItem> from an array, you should use the Cast<T>() method provided by LINQ to cast the non-generic enumerator to a generic one.
            return enumerator;
        }

    }
}