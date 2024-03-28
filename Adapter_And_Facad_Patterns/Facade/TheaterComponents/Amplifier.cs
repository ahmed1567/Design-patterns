using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }

        public void SetDvd()
        {
            Console.WriteLine("setting Dvd ");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("setting surround sound ");
        }


        public void SetVolume(int value)
        {
            Console.WriteLine($"Volume is {value} ");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
    }
}
