using System.Collections;
using System.Threading.Tasks;

namespace Iterator
{
    public class PancakeHouseMenu : Imenu
    {
        List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            
            menuItems.Add(new MenuItem ("K & B’s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true,    2.99));
            menuItems.Add(new MenuItem ("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            menuItems.Add(new MenuItem ("Blueberry Pancakes","Pancakes made with fresh blueberries", true, 3.49));
            menuItems.Add(new MenuItem ("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));
        }
        public void addItem(string name, string description, bool vegetarian, double price)
        {
            
            
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems); 
        }

        public IEnumerator<MenuItem> createIteratorV2() {
            IEnumerator<MenuItem> enumerator = menuItems.GetEnumerator();
            return enumerator;
        }
    }
}