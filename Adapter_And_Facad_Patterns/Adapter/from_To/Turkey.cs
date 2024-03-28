using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Turkey : ITurkey
    {
         public void fly()
        {
            Console.WriteLine(" fly short distance");

        }


        public void gobble()
        {
            Console.WriteLine("gobble gobble !!!");
        }


    }
}
