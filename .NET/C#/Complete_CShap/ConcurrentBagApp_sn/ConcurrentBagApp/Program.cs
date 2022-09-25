using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentBagApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> Bag = new ConcurrentBag<int>();
            // 정렬x, 특정값반환x, 순서무작위 => 그저 쓰레드를 사용할 때, 값 저장용도로 사용하면 될 것 같음

            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("Thread (1) has started");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Thread (1) added number " + i);
                    Bag.Add(i);
                }
                Console.WriteLine("Thread (1) is complete!");
            });

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread (2) has started");
                for (int i = 11; i <= 25; i++)
                {
                    Console.WriteLine("Thread (2) added number " + i);
                    Bag.Add(i);
                }
                Console.WriteLine("Thread (2) is complete!");
            });

            Thread t3 = new Thread(() =>
             {
                 t1.Join();
                 t2.Join();
                 // Join : 해당 인스턴스가 나타내는 쓰레드가 종료될때까지 쓰레드의 호출을 막는다.
                 // t1, t2 쓰레드가 끝날때까지 t3 쓰레드는 호출되지 못함.
                 Console.WriteLine("Thread (3) has started");
                 foreach (var item in Bag)
                 {
                     Console.WriteLine(item);
                 }
                 Console.WriteLine("Thread (3) is complete!");
             });

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
