using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaStore
    {
      
        public simpleFactory Factory { get; set; }
        private Pizza Pizza { get; set; }

        public PizzaStore(simpleFactory factory)
        {
            Factory = factory;
        }
        public Pizza OrderPizza(string name)
        {
            Pizza = Factory.CreatePizza(name);

            Pizza.prepare();
            Pizza.bake();
            Pizza.cut();
            Pizza.box();
            return Pizza;
        }
    }
}
