using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Esperesso : Coffees
    {
        public Esperesso() {
            description = "Esperesso";
        }


        public override double cost()
        {
            return 1.99;
        }

        public override string getDescription()
        {
            return description;
        }
    }
}
