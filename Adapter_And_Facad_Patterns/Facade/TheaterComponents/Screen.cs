using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Screen
    {
        public void Down () {
            Console.WriteLine("screen down");
        }


        public void Up () { 
            Console.WriteLine("screen up"); 
        }
    }
}
