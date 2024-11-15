using System.Collections;

namespace Iterator
{
    public class waitress 
    {

        PancakeHouseMenu pancakeHouseMenu;
        DinerMenu dinerMenu;

        public waitress(PancakeHouseMenu _pancakeHouseMenu, DinerMenu _dinerMenu)
        {
            this.pancakeHouseMenu = _pancakeHouseMenu;
            this.dinerMenu = _dinerMenu;
        }



        public void printMenu()
        {
            //Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            //Iterator dinerIterator = dinerMenu.createIterator();
            // using IEnumerable 
            
            IEnumerator pancakeIterator = pancakeHouseMenu.createIteratorV2();
            IEnumerator dinerIterator = dinerMenu.createIteratorV2();
            printMenu(pancakeIterator);
            printMenu(dinerIterator);
        }



        private void printMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                Console.WriteLine(menuItem.getName() + ", ");
                Console.WriteLine(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
                Console.WriteLine("-------------------------------");
            }

        }
    }
}