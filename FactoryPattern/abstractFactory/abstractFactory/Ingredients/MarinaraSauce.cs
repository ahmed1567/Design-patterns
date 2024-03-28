using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class MarinaraSauce : Ingredient, Isauce
    {
        public MarinaraSauce(string name, string description) : base(name, description)
        {
            Prepare();
        }

        public void Prepare()
        {
            Console.WriteLine($"preparing {Name} Sauce and the receipt is : {Description}");
        }
    }
}
