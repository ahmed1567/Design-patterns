using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class NoQuack : IQuacableBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I Can not Quack");
        }
    }
}
