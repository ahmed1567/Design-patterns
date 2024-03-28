using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class NYPizzaStore : PizzaStore

    {
        public NYPizzaStore(NyIngredientsFactory NyFactory) : base(NyFactory) { }
        
        //i will use just one Use Case
        public override Pizza CreatePizza(string SauceName, string ChesseName)
        {
            if (SauceName == "Tomato" && ChesseName == "Blue")
            {
                NYCheesePizza chessePizza = new NYCheesePizza(ingredientsFactory);
                chessePizza.prepare(SauceName, ChesseName);
                return chessePizza;
            }
            else if (SauceName == "Marinara" && ChesseName == "Blue")
            {
                NYGreekPizza greekPizza = new NYGreekPizza(ingredientsFactory);
                greekPizza.prepare(SauceName, ChesseName);
                return greekPizza;
            }
            else if (SauceName == "Marinara" && ChesseName == "Mozzarila")
            {
                NYPepperoniPizza pepperoniPizza = new NYPepperoniPizza(ingredientsFactory);
                pepperoniPizza.prepare(SauceName, ChesseName);
                return pepperoniPizza;
            }
            throw new Exception("please enter valid pizza");
        }
    }
}
