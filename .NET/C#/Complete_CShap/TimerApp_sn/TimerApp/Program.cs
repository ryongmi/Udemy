using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            // 정해진 시간마다 발생, 추가한 메서드를 호출한다.
            timer.Interval = 1000;
            // 시간 설정, 1000 = 1초
            //timer.Enabled = true;
            // 타이머 시작, 같은 명령어 : timer.Start();

            Console.WriteLine("Press (x) to exit");
            while (Console.Read() != 'x') ;
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Yes it is working " + DateTime.Now.ToLongTimeString());
        }
    }
}
