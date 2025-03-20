using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Work
{
    class String_StringBuilder
    {
        static void Main(string[] args)
        {
            //string name = "Bilal";
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    name = name + i;
            //}
            //sw1.Stop();

            //StringBuilder namee = new StringBuilder("Bilal");
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    namee.Append(i);
            //}
            //sw2.Stop();

            //Console.WriteLine($"Total time taken by String : {sw1.ElapsedMilliseconds}");
            //Console.WriteLine($"Total time taken by StringBuilder : {sw2.ElapsedMilliseconds}");

            StringBuilder sb = new StringBuilder("Hello Bilal");
            sb.Insert(5," C#");
            sb.AppendFormat("{0:c}", 25);
            sb.Remove(3,4);
            string newstring = sb.ToString();
            Console.WriteLine(sb);
            Console.WriteLine(newstring);
        }
    }
}
