using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class MozzarilaChesse : Ingredient, ICheese
    {
        public MozzarilaChesse(string name, string description) : base(name, description)
        {
            Prepare();
        }

        public void Prepare()
        {
            Console.WriteLine($"preparing {Name} Chesse and the receipt is : {Description}");
        }
    }
}
