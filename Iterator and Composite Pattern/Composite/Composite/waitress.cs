using System.Collections;

namespace Composite
{
    public class waitress 
    {

        MenuComponent menu;
        public waitress(MenuComponent _menu)
        {
            menu = _menu;
        }
        public void printMenu()
        {
            menu.print();
        }
    }
}