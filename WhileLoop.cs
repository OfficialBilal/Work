﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Loop Ended");
        }
    }
}
