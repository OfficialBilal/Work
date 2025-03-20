using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class ParamsDemo
    {
        public static int add(params int[] num)
        {
            int sum = 0;
            foreach(int i in  num)
            { 
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ParamsDemo.add(10, 20, 30, 40, 50));
        }
    }
}
