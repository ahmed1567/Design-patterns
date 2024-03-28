using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using strategy;

namespace strategy
{
    public class Millard : Duck
    {
        public Millard(string name, string description) : base(name, description)
        {
            FlyBehavior = new FlyableBehavior();
            QuackBehavior = new NoQuack();
        }

        public override void DuckDetails()
        {
            Console.WriteLine($"Duck name is : {Name}");
            Console.WriteLine($"Duck describtion is : {Description}");
            FlyBehavior.Fly();
            QuackBehavior.Quack();
        }
    }
}
