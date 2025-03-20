using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee()
            {
                id = 1,
                name = "Bilal",
                age = 33,
                designation = "Teacher"
            };

            Employee emp2 = new Employee()
            {
                id = 2,
                name = "Ali",
                age = 43,
                designation = "Business Man"
            };

            Employee emp3 = new Employee()
            {
                id = 3,
                name = "Ismaeel",
                age = 23,
                designation = "Engr."
            };

            Dictionary<int, Employee> myemp = new Dictionary<int, Employee>();
            myemp.Add(emp1.id, emp1);
            myemp.Add(emp2.id, emp2);
            myemp.Add(emp3.id, emp3);

            Console.WriteLine(myemp.Count(emp => emp.Value.age > 25));






            Dictionary<string, string> mywords = new Dictionary<string, string>();
            {
                mywords.Add("A", "A for Apple");
                mywords.Add("B", "B for Ball");
                mywords.Add("C", "C for Cat");
                mywords.Add("D", "D for Dog");

                foreach(KeyValuePair<string, string>  word in mywords)
                {
                    Console.WriteLine("The Key Value is : " + word.Key + " and Value is " + word.Value );
                }

                foreach (string keys in mywords.Keys)
                {
                    Console.WriteLine("The Key Value is : " + keys);
                }

                foreach(string value in mywords.Values)
                {
                    Console.WriteLine("The Key Value is : " + value);
                }

                if(mywords.ContainsKey("F"))
                {
                    Console.WriteLine("Key Found");
                }
                else
                {
                    Console.WriteLine("Key Not Found");
                }

                string Name;
                mywords.TryGetValue("A", out Name);
                Console.WriteLine(Name);

            }
        }
    }
}
