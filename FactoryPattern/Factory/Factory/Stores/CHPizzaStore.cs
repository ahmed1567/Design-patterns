using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CHPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            if (name == "cheese")
            {
                return new ChCheesePizza();
            }
            else if (name == "greek")
            {
                return new ChGreekPizza();
            }
            else if (name == "pepperoni")
            {
                return new ChPepperoniPizza();
            }
            throw new Exception("please enter valid pizza ");
        }
    }
}
