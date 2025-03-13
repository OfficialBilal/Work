using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            int num = 5;

            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {i*num}");
            }
            Console.WriteLine("Loop Ended");
        }
    }
}
