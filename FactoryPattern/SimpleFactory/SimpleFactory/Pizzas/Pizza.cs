using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Pizza
    {
        public string Name { get; set; }

        public void prepare(){
            Console.WriteLine($"start preparing the {Name} pizza");
        }
        public void bake(){
            Console.WriteLine($"start baking the {Name} pizza");
        }
        public void cut(){
            Console.WriteLine($"star cutting the {Name} pizza");
        }
        public void box(){
            Console.WriteLine($"start boking the {Name} pizza");
        }
        


    }
}
