﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Actions.Removing
{
    public class AllRemove : IRemoving
    {
        public void Removing()
        {
            Console.WriteLine("I can remove everything");
        }
    }
}
