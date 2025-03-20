using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class QueueDemo
    {
        void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(32);
            q.Enqueue(32.3);
            q.Enqueue("Bilal");
            q.Enqueue("C# Tutorial");
            q.Enqueue('B');

            Console.WriteLine(q.Count);

            q.Dequeue(); //FIFO

            Console.WriteLine(q.Peek());

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
            
            Console.WriteLine(q.Contains("Bilal"));
            Console.WriteLine(q.Count);

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }

            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
