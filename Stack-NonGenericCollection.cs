using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Stack_NonGenericCollection
    {
        void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("Bilal");
            st.Push("Hello");
            st.Push(343);

            foreach(object obj in st)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------");

            st.Pop();
            st.Push(34353);

            foreach (object obj in st)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
