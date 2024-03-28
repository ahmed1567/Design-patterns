using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class NyIngredientsFactory : IingredientsFactory
    {


        public Isauce createSauce(string name , string description)
        {
            if (name == "Tomato")
            {
                return new TomatoSauce($"{name}" , $"{description}");
            }
            else if (name == "Marinara" )
            {
                return new MarinaraSauce($"{name}", $"{description}");
            }
            throw new Exception("please enter valid sauce name ");
        }

        public ICheese createCheese(string name, string description)
        {
            if (name == "Mozzarila")
            {
                return new MozzarilaChesse($"{name}", $"{description}");
            }
            else if (name == "Blue")
            {
                return new BlueChesse($"{name}", $"{description}");
            }
            throw new Exception("please enter valid cheese name ");
        }
    }
}
