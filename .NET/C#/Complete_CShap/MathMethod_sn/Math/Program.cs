using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 4.3;

            Console.WriteLine("Ceiling : " + Math.Ceiling(x));
            // Ceiling : 올림

            Console.WriteLine("Floor : " + Math.Floor(x));
            // Floor : 내림

            Console.WriteLine("Round : " + Math.Round(x, 1));
            // Round : 반올림, 몇번째 소수점 자리에서 반올림 할지 정할 수 있음

            Console.WriteLine("Truncate : " + Math.Truncate(x));
            // Truncate : 정수 반환

            int y = 9;
            int z = 4;

            Console.WriteLine("Max : " + Math.Max(y, z));
            // Max : 큰값 반환

            Console.WriteLine("Min : " + Math.Min(y, z));
            // Min : 작은값 반환

            Console.WriteLine("Pow : " + Math.Pow(y, z));
            // Pow : y의 z제곱 반환

            Console.WriteLine("PI : " + Math.PI);
            // PI : 파이 값
        }
    }
}
