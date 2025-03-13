using System;
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
            int number = 3;
            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine($"{number} X {i} = {number*i}");
                i++;
            }
            Console.WriteLine("Loop Ended");
        }
    }
}
