﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class DvD
    {
        public void On()
        {
            Console.WriteLine("dvd on");
        }

        public void Play(string name)
        {
            Console.WriteLine($"starting {name}");
        }

        public void Stop() 
        {
            Console.WriteLine("dvd stop");
        }

        public void Off()
        {
            Console.WriteLine("dvd off");
        }
    }
}
