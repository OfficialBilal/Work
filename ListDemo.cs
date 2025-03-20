using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class ListDemo
    {
         static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                name = "Bilal",
                age = 33,
                designation = "Teacher"
            };

            Employee emp2 = new Employee()
            {
                name = "Ali",
                age = 43,
                designation = "Business Man"
            };

            Employee emp3 = new Employee()
            {
                name = "Ismaeel",
                age = 23,
                designation = "Engr."
            };

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist.Add(emp3);

           // Console.WriteLine(emplist.Exists (emp => emp.name.StartsWith("b".ToUpper())));

            Employee emp = emplist.Find(e => e.age > 20);

            Console.WriteLine($"Employe name is {emp.name}, age is {emp.age} and designation is {emp.designation}");

            //foreach (Employee em in emplist)
            //{
            //    Console.WriteLine($"Employe name is {em.name}, age is {em.age} and designation is {em.designation}");
            //}

            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Add(5);

            ////ints.AddRange(ints);
            ////ints.Insert(1, 20);

            //ints.InsertRange(3, ints);

            //foreach(int i in ints)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> names = new List<string>();
            //names.Add("Muhammad ");
            //names.Add("Bilal ");
            //names.Add("Muhammad Bilal");

            //Console.WriteLine($"Currunt Capacity is : {ints.Capacity}");


        }
    }
}
