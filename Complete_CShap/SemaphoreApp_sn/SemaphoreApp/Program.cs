﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreApp
{
    class Program
    {
        private static Semaphore semaphore = new Semaphore(1, 2);
        // Semaphore(x,y) : 실행가능한 쓰레드 개수를 제한하는 클래스, x:처음 실행가능한 쓰레드 개수, y: 최대 실행가능한 쓰레드 개수
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 1; d++)
                    {
                        UseResource();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting to enter", Thread.CurrentThread.Name);
            semaphore.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            semaphore.Release();
            Console.WriteLine("{0} has left the critical section", Thread.CurrentThread.Name);
        }
    }
}
