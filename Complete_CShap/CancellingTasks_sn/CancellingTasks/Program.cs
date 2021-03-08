using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CancellingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    // IsCancellationRequested : 토큰의 취소 요청 여부를 반환함
                    {
                        Console.WriteLine("Task is cancelled!");
                        return;
                    }
                    else
                        Console.WriteLine(i + 1);
                }
                Console.WriteLine("Task is Complete");
            });
            task.Start();

            //Thread.Sleep(3000);
            //cancellationTokenSource.Cancel();

            cancellationTokenSource.CancelAfter(2500);
            // 위처럼 쓰레드를 일정시간 정지시킨후 취소요청을 보내거나, 아예 CancelAfter() 메서드를 이용하여 한줄로 사용가능. ( 위, 아래 동일한 결과 )

            Console.ReadLine();
        }
    }
}
