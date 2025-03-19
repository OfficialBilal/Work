using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Hash_Table
    {
        void Main(string[] args)
        {
            HashSet<int> t = new();

            Hashtable ht = [];
            ht.Add("Id", 33);
            ht.Add("Name", "Bilal");
            ht.Add(105, "Developer");

            var  htt = new Hashtable()
            {
                {"City", "Lahore" },
                {"Phone", 03001234567 }
            };

            foreach(object o in ht.Keys)
            {
                Console.WriteLine(o + " : " + ht[o]);
            }
            ht.Remove("Id");

            Console.WriteLine("-------------------");

            foreach (object o in ht.Keys)
            {
                Console.WriteLine(o + " : " + ht[o]);
            }

            Console.WriteLine(ht["Name"]?.GetHashCode());
            Console.WriteLine(ht.Count);

            //Console.WriteLine(ht["Id"]);
            //Console.WriteLine(ht[105]);
            //Console.WriteLine(htt["Phone"]);
        }
    }
}
