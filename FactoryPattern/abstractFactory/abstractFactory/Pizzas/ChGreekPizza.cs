using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class ChGreekPizza : Pizza
    {
        public ChGreekPizza(IingredientsFactory ingredientsfactory) : base(ingredientsfactory)
        {
            Name = "chgreek";
        }
        public override void prepare(string SauceName, string ChesseName)
        {
            if (SauceName == "Tomato" && ChesseName == "Blue")
            {

                Sauce = ingredientsFactory.createSauce(SauceName, "Tomato sauce in Chicago city way");
                Chesse = ingredientsFactory.createCheese(ChesseName, "Blue chesse in chicago style");

            }
            else if (SauceName == "Tomato" && ChesseName == "Mozzarila")
            {

                Sauce = ingredientsFactory.createSauce(SauceName, "Tomato sauce in Chicago city way");
                Chesse = ingredientsFactory.createCheese(ChesseName, "Mozzarila chesse in chicago style");

            }
            else if (SauceName == "Marinara" && ChesseName == "Blue")
            {

                Sauce = ingredientsFactory.createSauce(SauceName, "Marinara sauce in Chicago city way");
                Chesse = ingredientsFactory.createCheese(ChesseName, "Blue chesse in chicago style");

            }
            else if (SauceName == "Marinara" && ChesseName == "Mozzarila")
            {

                Sauce = ingredientsFactory.createSauce(SauceName, "Marinara sauce in Chicago city way");
                Chesse = ingredientsFactory.createCheese(ChesseName, "Mozzarila chesse in chicago style");
            }


        }
    }
}
