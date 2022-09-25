using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("Cavin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
