using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
  
            string name;
            string description;
            bool vegetarian = false;
            double price;
            public MenuItem(string name,
            string description,
            bool vegetarian,
            double price)
            {
                this.name = name;
                this.description = description;
                this.vegetarian = vegetarian;
                this.price = price;
            }

            public override string getName()
            {
                return name;
            }

            public override string getDescription()
            {
                return description;
            }

            public override double getPrice()
            {
                return price;
            }

            public override bool isVegetarian()
            {
                return vegetarian;
            }
            public override void print()
            {
                Console.WriteLine(" " +getName());
                if (isVegetarian())
                {
                    Console.WriteLine("(v)");
                }
                Console.WriteLine(", " +getPrice());
                Console.WriteLine(" -- " +getDescription());
            }

        public override void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public override MenuComponent getChild(int i)
        {
            throw new NotImplementedException();
        }
    }
}
