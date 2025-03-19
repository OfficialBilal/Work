using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class If_Else
    {
        void Main(string[] args)
        {
            Console.WriteLine("Enter your Marks");
            int num = int.Parse(Console.ReadLine());

            if (num > 90)
            {
                Console.WriteLine("You got A+ Grade");
            }
            else if (num > 70)
            {
                Console.WriteLine("You got B Grade");
            }
            else if (num > 50)
            {
                Console.WriteLine("You got C Grade");
            }
            else if (num >= 33)
            {
                Console.WriteLine("You got E Grade");
            }
            else
            {
                Console.WriteLine("You are Failed");
            }
        } 
    }
}
