using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Nested_ForLoop
    {
      void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello");

                for(int b = 0; b < 3; b++)
                {
                    Console.WriteLine("Hy");
                }

            }
        }
       
    }
}
