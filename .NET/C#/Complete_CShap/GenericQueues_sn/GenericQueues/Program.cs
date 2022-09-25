using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<DateTime> arrivals = new Queue<DateTime>();

            arrivals.Enqueue(new DateTime(2017, 01, 01));
            arrivals.Enqueue(new DateTime(2018, 12, 24));
            arrivals.Enqueue(new DateTime(2019, 05, 25));

            Console.WriteLine($"At the top {arrivals.Peek()}");
            Console.WriteLine("------------------------");
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            arrivals.Dequeue();
            Console.WriteLine("------------------------");
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
