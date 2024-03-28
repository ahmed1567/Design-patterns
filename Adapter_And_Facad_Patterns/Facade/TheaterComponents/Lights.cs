using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Lights
    {
        public void Dim(int value)
        {
            Console.WriteLine($"set lights dim to {value}");
        }

        public void On()
        {
            Console.WriteLine("lights on");
        }
    }
}
