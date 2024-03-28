
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public abstract class Pizza
    {
        public Isauce Sauce { get; set; }
        public ICheese Chesse { get; set; }

        public IingredientsFactory ingredientsFactory { get; set; }

        public Pizza(IingredientsFactory ingredientsfactory)
        {
            ingredientsFactory = ingredientsfactory;
        }
        public string Name { get; set; }

        public abstract void prepare(string SauceName , string ChesseName);
    
        public void bake(){
            Console.WriteLine($"start baking the {Name} pizza");
        }
        public void cut(){
            Console.WriteLine($"star cutting the {Name} pizza");
        }
        public void box(){
            Console.WriteLine($"start boking the {Name} pizza");
        }
        


    }
}
