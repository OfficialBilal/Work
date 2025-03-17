using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class OperatorOverloading
    {
        class NewClass
        {
            public string Name;
            public int age;


            public static NewClass operator +(NewClass a, NewClass b)
            {
                NewClass c = new NewClass();
                c.Name = a.Name + b.Name;
                c.age = a.age + b.age;
                return c;
            }
        }

        static void Main(string[] args)
        {
            NewClass a = new NewClass();
            a.Name = "Muhmmad ";
            a.age = 10;

            NewClass b = new NewClass();
            b.Name = "Bilal";
            b.age = 15;

            NewClass c = new NewClass();
            c = a + b;

            Console.WriteLine(c.Name);
            Console.WriteLine(c.age);

            Console.ReadLine();
        }
    }
}
