using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuacableBehavior QuackBehavior { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Duck(  string name , string description) { 
            Name = name;
            Description = description;
        }

        public abstract void DuckDetails();

    }
}
