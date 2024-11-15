using System.Collections;
using System.Threading.Tasks;

namespace Composite
{
    public class PancakeHouseMenu : Menu
    {
        public PancakeHouseMenu(string name, string description) : base(name, description)
        {
           add(new MenuItem ("K & B’s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true,    2.99));
           add(new MenuItem ("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
           add(new MenuItem ("Blueberry Pancakes","Pancakes made with fresh blueberries", true, 3.49));
           add(new MenuItem ("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));
        }
    }
}