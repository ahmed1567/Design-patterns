using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public interface IingredientsFactory
    {

        Isauce createSauce(string name, string description);
        ICheese createCheese(string name, string description);
    }
}
