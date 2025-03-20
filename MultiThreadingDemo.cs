using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class MultiThreadingDemo
    {
        public static void Func1()
        {
            for (int i = 0; i <=50; i++)
            {
                Console.WriteLine("Func1 " + i);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Func2 " + i);
                if(i == 25)
                {
                    Console.WriteLine("Function 2 is going to sleep for 8 sec");
                    Thread.Sleep(8000);
                }
            }
        }
        public static void Func3()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Func3 " + i);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Func1);
            Thread t2 = new Thread(Func2);
            Thread t3 = new Thread(Func3);

            t1.Start();
            t2.Start();
            t3.Start();

            //MultiThreadingDemo.Func1();
            //MultiThreadingDemo.Func2();
            //MultiThreadingDemo.Func3();

        }
    }
}
