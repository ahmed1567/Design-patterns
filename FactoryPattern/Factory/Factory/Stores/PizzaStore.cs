using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PizzaStore
    {
      
        private Pizza Pizza { get; set; }


        public Pizza OrderPizza(string name)
        {
            Pizza = CreatePizza(name);

            Pizza.prepare();
            Pizza.bake();
            Pizza.cut();
            Pizza.box();
            return Pizza;
        }
        public abstract Pizza CreatePizza(string name);// factory method now is abstract method instead of one Factory , stores will inhert this class and create their own pizzas 
    }
}
