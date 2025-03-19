using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string getName()
    {
        return this.Name;
    }
    public int getAge()
    {
        return this.Age;
    }
    ~Person()
    {
        Console.WriteLine($"Destructor Invoked : {Name}");
    }
}

class Destructors
{
    public void Main(string[] args)
    {
        Test(); 
        GC.Collect();
        Console.ReadLine();
    }

    private static void Test()
    {
        Person a = new Person("Bilal", 24);
        Execture(a);
    }

    private static void Execture(Person a)
    {
        Person b = new Person("Ali", 25);
        Console.WriteLine(a.getName());
        Console.WriteLine(a.getAge());
        Console.WriteLine(b.getName());
        Console.WriteLine(b.getAge());
    }
}
