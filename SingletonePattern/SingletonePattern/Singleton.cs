﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePattern
{
    public class Singleton
    {
        private static Singleton uniqueInstance;
       
        private Singleton() { }
        public static Singleton getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
        // other useful methods her
    }

}
