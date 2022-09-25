﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deadlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Files file = new Files();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt");
            }
        }
    }

    class Files
    {
        public Object thisLock = new Object();
        public void Write(object path)
        {
            lock (thisLock)
            // lock : 중괄호 안에 있는 구문을 두개 이상의 쓰레드가 한번에 실행, 또는 접근하여 사용하지 못하게,
            //        하나의 쓰레드만 사용 가능하고, 사용중인 쓰레드의 작업이 끝날때까지 다른 쓰레드는 사용하지 못하게 한다.
            {
                // some logic of writing in files goes in where
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed");
            }
        }

        public void Read(object path)
        {
            lock (thisLock)
            {
                // some logic of writing in files goes in where
                Console.WriteLine("Reading from " + path);
                Thread.Sleep(1000);
                Console.WriteLine("Reading process has been completed");
            }
        }
    }
}
