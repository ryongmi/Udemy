using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;
            PerformAddOperation(a, b);

            c = 15;
            d = 10;
            PerformAddOperation(c, d);
        }

        static void PerformAddOperation(int a, int b)
        {
            int addResult = 0;
            addResult = a + b;
            Console.WriteLine($"{a} + {b} = {addResult}");
            DisplayMessage();
        }

        /*
        static void PerformAddOperation(int a, int b, out int result)
        {
            result = a + b;
        }
        */
        // out 키워드를 사용하여 반환값 받는 메서드

        static void DisplayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by ahmad");
            Console.WriteLine("Finished on time : " + DateTime.Now.ToShortTimeString());
        }
    }
}
