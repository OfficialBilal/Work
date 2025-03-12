using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class NestedSwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Pizza Flavour");
            string pizza = (Console.ReadLine());

            switch (pizza)
            {
                case "Fajita":
                    Console.WriteLine("You have Selected Fajita Flavour");
                    break;
                case "Cheese":
                    Console.WriteLine("You have Selected Cheese Flavour");
                    break;
                case "Vegetable":
                    Console.WriteLine("Select Vegetable in your Pizza");
                    string veg = Console.ReadLine();
                    {
                        switch (veg)
                        {
                            case "Olive":
                                Console.WriteLine("You have Selected Olive in Vegetable Flavour");
                                break;
                            case "Onion":
                                Console.WriteLine("You have Selected Onion in Vegetable Flavour");
                                break;
                            case "Tomato":
                                Console.WriteLine("You have Selected Tomato in Vegetable Flavour");
                                break;
                            default:
                                Console.WriteLine("Your selected Vegetable not available");
                                break;
                        }
                    }
                    break;
                case "Supreme":
                    Console.WriteLine("You have Selected Supreme Flavour");
                    break;
                default:
                    Console.WriteLine("Your selected Pizza flavour not available");
                    break;
            }
        }
    }
}
