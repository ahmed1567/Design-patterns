using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class NoFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I Can not Fly");
        }
    }
}
