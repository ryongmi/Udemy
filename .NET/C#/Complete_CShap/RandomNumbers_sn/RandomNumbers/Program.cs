using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = 0;

            x = rand.Next(1, 7);
            // 1~6 사이의 정수 값 반환

            Console.WriteLine("Dice : " + x);

            double y = 0;
            y = rand.NextDouble();
            // 0.0 ~ 0.999999~ 사이의 소수 값 반환
            Console.WriteLine("Random double no is " + Math.Round(y, 2));
        }
    }
}
