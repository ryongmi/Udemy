using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorClassApp
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
        public void Write(object path)
        {
            Monitor.Enter(path);
            // Monitor : lock과 동일한 기능을 하는 클래스.
            // lock의 동작방식이 Monitor 클래스의 동작방식과 같다. Monitor의 구문을 간소화한 것이 lock
            // lock의 중괄호는 Monitor의 try구문이고, lock에서 명시적으로 쓰진 않지만(구문을 코딩하진 않는다), 자동적으로 finally에서 Exit, 점유를 해제한다.
            try
            {
                // some logic of writing in files goes in where
                Console.WriteLine("Writing in " + path);
                //Thread.Sleep(2000);
                // Sleep 메서드를 실행하면 일시적으로 점유가 풀리게 되어 대기중인 메서드가 실행된다.
                Console.WriteLine("Writing process has been completed");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        public void Read(object path)
        {
            // some logic of reading files goes in where
            Console.WriteLine("Reading from " + path);
            Thread.Sleep(1000);
            Console.WriteLine("Reading process has been completed\n");
        }
    }
}
