using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Calculator
    {
        static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The addition result is {result}");
        }
        static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"The Substraction result is {result}");
        }
        static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"The Multiplication result is {result}");
        }
        static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"The Division result is {result}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator (+, -, *, /)");
            string op = Console.ReadLine();

            if(op.Equals("+"))
            {
                Calculator.Addition(num1, num2);
            }

            else if (op.Equals("-"))
            {
                Calculator.Substraction(num1, num2);
            }

            else if (op.Equals("*"))
            {
                Calculator.Multiplication(num1, num2);
            }

            else if (op.Equals("/"))
            {
                Calculator.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
