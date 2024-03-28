using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightOnCommand : ICommand
    {
        Light Light { get; set; }
        public LightOnCommand(Light light)
        {
            Light = light;   
        }
        public void execute()
        {
            Light.On();
            

        }
    }
}
