using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public abstract class PizzaStore
    {
      
        private Pizza Pizza { get; set; }
        public IingredientsFactory ingredientsFactory { get; set; }
        public PizzaStore(IingredientsFactory ingredientsfactory)
        {
            ingredientsFactory = ingredientsfactory;
        }

        public Pizza OrderPizza(string SauceName, string ChesseName)
        {
            Pizza = CreatePizza(SauceName,ChesseName);

            Pizza.bake();
            Pizza.cut();
            Pizza.box();
            return Pizza;
        }
        public abstract Pizza CreatePizza(string SauceName, string ChesseName);// factory method now is abstract method instead of one Factory , stores will inhert this class and create their own pizzas 
    }
}
