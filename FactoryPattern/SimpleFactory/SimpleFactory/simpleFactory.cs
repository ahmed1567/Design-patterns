using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class simpleFactory
    {
        public Pizza pizza;

        // note that CreatePizza called FactoryMethode
        public Pizza CreatePizza(string name)
        {
            if (name == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (name == "greek") {
                pizza = new GreekPizza();
            }
            else if (name ==  "pepperoni") {
                pizza = new PepperoniPizza();
            }
            return pizza;
        }
    }
}
