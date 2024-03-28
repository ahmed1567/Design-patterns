using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NYPizzaStore : PizzaStore

    {
        public override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
            {
                return new NYCheesePizza();
            }
            else if (name == "greek")
            {
                return new NYGreekPizza();
            }
            else if (name == "pepperoni")
            {
                return new NYPepperoniPizza();
            }
            throw new Exception("please enter valid pizza ");
        }
    }
}
