using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingThreads
{
    class Program
    {
        static Thread t1;
        static Thread t2;

        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHiEnglish));
            // ThreadStart(메서드 A) -> 스레드가 실행되면 실행할 메서드를 설정(메서드 A로 설정함)
            t1.Name = "Thread Number 1 (English)";
            // 스레드 객체 t1의 이름 설정
            t1.Start();
            // t1 스레드 실행

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread Number 2 (Spanish)";
            t2.Start();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("String to execute " + Thread.CurrentThread.Name);
            // CurrentThread -> 현재 실행중인 스레드를 가져온다. 현재 영어메서드를 실행하는 스레드 객체는 t1
            // Name -> 스레드의 이름을 가져온다. t1의 이름을 출력함

            for (int i = 0; i < 50; i++)
            {
                /*
                Thread.Sleep(1000);
                // Sleep(Time) -> 스레드를 정해진 시간동안 멈춰놓음. Time : 멈춰 놓을 시간, 1000 = 1초 
                */

                /*
                if (i == 31)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " is about to be aborted");
                    t1.Abort();
                    // Abort() : 스레드를 종료하는 메서드, 실행하면 예외를 반환하고 스레드가 종료된다.
                }
                */

                Console.WriteLine(i + "Hi...");
                t2.Join();
                // Join() -> t2 스레드를 실행하고, t2가 끝날때까지 t1은 대기상태에 놓임
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("String to execute " + Thread.CurrentThread.Name);

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(new TimeSpan(0, 0, 1));
                // Sleep 메서드의 시간을 설정할 수 있는 다른 방법
                Console.WriteLine(i + "Hola...");
            }
        }
    }
}
