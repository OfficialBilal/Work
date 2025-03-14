using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Jump_Statement
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i <= 10; i++)
            //{ 
            //    if ( i == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Loop Ended");

            //Console.ReadLine();

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    goto stop;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("Loop Ended");

        stop:

            Console.WriteLine("Hacking...");


            Console.ReadLine();

        }
    }
}
