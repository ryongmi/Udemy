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
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(SayHiEnglish));
            // ThreadStart(메서드 A) -> 스레드가 실행되면 실행할 메서드를 설정(메서드 A로 설정함)
            t1.Name = "Thread Number 1 (English)";
            // 스레드 객체 t1의 이름 설정
            t1.Start();
            // t1 스레드 실행

            Thread t2 = new Thread(new ThreadStart(SayHiSpanish));
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
                Console.WriteLine(i + "Hi...");
            }
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("String to execute " + Thread.CurrentThread.Name);

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i + "Hola...");
            }
        }
    }
}
