using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Loop(100_000_000);
            watch.Stop();

            Console.WriteLine("Milliseconds " + watch.Elapsed.Milliseconds);
            Console.WriteLine("Total Milliseconds " + watch.Elapsed.TotalMilliseconds);
            Console.WriteLine("Total Seconds " + watch.Elapsed.TotalSeconds);
            Console.WriteLine("Seconds " + watch.Elapsed.Seconds);

            Console.WriteLine(watch.Elapsed.Ticks);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process done");
        }
    }
}
