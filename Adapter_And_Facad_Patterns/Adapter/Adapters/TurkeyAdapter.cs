using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

public class TurkeyAdapter : IDuck
{
    ITurkey Turkey { get; set; }

    public TurkeyAdapter(ITurkey turkey)
    {
        Turkey = turkey;
    }
    public void fly()
    {
        
        for (int i = 0; i < 5; i++)
        {
            Turkey.fly();
        }
        //  fly of Duck is 5 times fly of Turkey , in general when we use adapter pattern we should be awarn of specs of the interface we will convert from or To 
        // Ensure that the methods and properties in the Target Interface match the requirements of your system.
    }

    public void quack()
    {
        Turkey.gobble();
    }
}
