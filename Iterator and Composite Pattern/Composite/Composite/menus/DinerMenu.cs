using System.Drawing;

namespace Composite
{
    public class DinerMenu :Menu
    {

        public DinerMenu(string name, string description) : base(name, description)
        {

            add(new MenuItem("Hotdog","A hot dog, with saurkraut, relish, onions, topped with cheese",false, 3.05));
            add( new MenuItem("Soup of the day","Soup of the day, with a side of potato salad", false, 3.29));
            add(new MenuItem("BLT","Bacon with lettuce & tomato on whole wheat", false, 2.99));
            add( new MenuItem("Vegetarian BLT","(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            
        }
    }
}