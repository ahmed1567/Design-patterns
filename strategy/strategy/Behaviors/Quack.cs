using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Quack : IQuacableBehavior
    {
        void IQuacableBehavior.Quack()
        {
            Console.WriteLine("I can Quack");
        }
    }
}
