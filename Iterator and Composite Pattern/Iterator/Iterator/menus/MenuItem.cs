using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Iterator
{
    public class MenuItem
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

            public string getName()
            {
                return name;
            
            }

            public string getDescription()
            {
                return description;
            }

            public double getPrice()
            {
                return price;
            }

            public bool isVegetarian()
            {
                return vegetarian;
            }
        

    }
}
