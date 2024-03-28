using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        Coffees _coffees;
        public Mocha( Coffees coffee)
        {
            _coffees = coffee;
        }


        public override string getDescription()
        {
            return _coffees.getDescription() +  " Mocha";
        }

        public override double cost()
        {
            return _coffees.cost() + 0.20;
        }
    }
}
