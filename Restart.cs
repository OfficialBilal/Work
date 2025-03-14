using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Restart
    {
        static void Main(string[] args)
        {
            int FN, SN;
            string choice;
        start:

            while (true)
            {
                Console.WriteLine("Enter First Number");
                if (int.TryParse(Console.ReadLine(), out FN))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

            while(true)
            {
                Console.WriteLine("Enter Second Number");
                if (int.TryParse(Console.ReadLine(), out SN))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

            Console.WriteLine("Do you to Continue again? Yes / No");
            choice = Console.ReadLine().ToLower();

            if (choice != "yes" && choice != "no")
            {
                Console.WriteLine("Invalid Choice, PLease try again");
            }
            else if (choice == "no")
            {
                Console.WriteLine("Program tu warr gya");
            }
            else
            {
                goto start;
            }
        }
    }
}
