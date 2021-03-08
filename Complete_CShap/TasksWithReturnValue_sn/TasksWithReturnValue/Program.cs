using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(() =>
            // Task<int> : Task는 반환값이 없는 비동기 작업을 수행하지만, 제네릭을 붙여주면, 지정한 타입의 반환 값이 있는 비동기 작업을 수행한다. ( 제네릭을 붙이면 반환값이 있음 )
            {
                int result = 0;
                for (int i = 0; i <= 5; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task.Start();
            Console.WriteLine(task.Result);

            Console.ReadLine();
        }
    }
}
