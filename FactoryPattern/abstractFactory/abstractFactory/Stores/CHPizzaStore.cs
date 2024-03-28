using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class CHPizzaStore : PizzaStore
    {
        public CHPizzaStore(ChIngredientsFactory ChFactory) : base(ChFactory) { }
        
        //i will use just one Use Case
        public override Pizza CreatePizza(string SauceName, string ChesseName)
        {
            if (SauceName == "Tomato" && ChesseName == "Blue")
            {
                ChCheesePizza chessePizza= new ChCheesePizza(ingredientsFactory);
                chessePizza.prepare(SauceName, ChesseName);
                return chessePizza;
            }
            else if (SauceName == "Marinara" && ChesseName == "Blue")
            {
               ChGreekPizza greekPizza = new ChGreekPizza(ingredientsFactory);
               greekPizza.prepare(SauceName, ChesseName);
                return greekPizza;
            }
            else if (SauceName == "Marinara" && ChesseName == "Mozzarila")
            {
                ChPepperoniPizza pepperoniPizza = new ChPepperoniPizza(ingredientsFactory);
                pepperoniPizza.prepare(SauceName, ChesseName);
                return pepperoniPizza;
            }
            throw new Exception("please enter valid pizza");
        }
    }
}
