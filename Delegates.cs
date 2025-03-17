using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public delegate void Calculation(int a, int b);

    class Delegates
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The addition result is: {result}");
        }
        public static void Subtraction(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The Subtraction result is: {result}");
        }
        public static void Multiplication(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The Multiplication result is: {result}");
        }
        public static void Division(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The Division result is: {result}");
        }
        public static void Main(string[] args)
        {
            Calculation x = new Calculation(Delegates.Addition);
            x(10,10);
            x = Multiplication;
            x(2, 2);
            Console.ReadLine();
        }
    }
}
