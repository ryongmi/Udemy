using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexApp
{
    class Program
    {
        private static Mutex mut = new Mutex();
        // Mutex : lock, Monitor 클래스와 마찬가지로 하나의 쓰레드가 점유하여 사용할 수 있게 해주는 클래스.
        //         하지만 lock, Monitor보다 약 50배 느려, 하나의 프로세스에서만 사용할 경우 lock이나 Monitor을 사용하는것이 좋다.

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 2; d++)
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
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
            mut.WaitOne();
            // WaitOne() -> Mutex를 획득하는 메서드, 괄호안에 숫자를 넣어 그 시간동안만 점유하게 할 수 있음.

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            mut.ReleaseMutex();
            // ReleaseMutex() -> Mutex 해제 메서드
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
        }
    }
}
