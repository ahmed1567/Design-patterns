using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("projector start");
        }
        public void WideScreenMode()
        {
            Console.WriteLine("projector wide screen mode starting");
        }

        public void Off () 
        { 
            Console.WriteLine("projector off"); 
        }
    }
}
