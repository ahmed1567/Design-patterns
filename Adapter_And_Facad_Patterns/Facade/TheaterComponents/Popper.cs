using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Popper
    {
        public void On()
        {
            Console.WriteLine("popper start ");
        }

        public void Pop()
        {
            Console.WriteLine("pop corn time");
        }

        public void Off()
        {
            Console.WriteLine("popper off");
        }
    }
}
