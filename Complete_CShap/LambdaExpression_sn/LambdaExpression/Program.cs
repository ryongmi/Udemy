using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);

    class Program
    {
        static void Main(string[] args)
        {
            // => 뒤의 오는 문장을 반환함

            Multiply MultiplyNumber = n => n * 3;
            // n*3을 반환
            Console.WriteLine(MultiplyNumber(30));

            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            // 출력문을 반환
            Message();
        }
    }
}
