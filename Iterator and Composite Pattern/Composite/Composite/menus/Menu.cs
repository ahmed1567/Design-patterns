using System.Collections;

namespace Composite
{
    public class Menu : MenuComponent 
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }
        public override string getName()
        {
            return name;
        }
        public override string getDescription()
        {
            return description;
        }
        public override void print()
        {
            Console.WriteLine("\n" +getName());
            Console.WriteLine(", " +getDescription());
            Console.WriteLine("---------------------");
            IEnumerator<MenuComponent> enumerator = menuComponents.Cast<MenuComponent>().GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent =(MenuComponent)enumerator.Current;
                menuComponent.print();
                /*
                 Look! We get to use an Iterator. We 
                 use it to iterate through all the Menu’s 
                 components... those could be other Menus, 
                 or they could be MenuItems. Since both 
                 Menus and MenuItems implement print(), we 
                 just call print() and the rest is up to them.
                 */
            }
        }

        public override double getPrice()
        {
            throw new NotImplementedException();
        }

        public override bool isVegetarian()
        {
            throw new NotImplementedException();
        }
    }
}