﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Coffees 
    {
        public string description;

        public abstract string getDescription();
        public abstract double cost();

    }
}
