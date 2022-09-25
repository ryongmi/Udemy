using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAdmin() ? "Yes an admin" : "No not an admin");
            Console.WriteLine(!IsAdmin() ? "Yes an admin" : "No not an admin");
            // 조건부 연산자 : bool 변수 ? True일 때 출력값(실행 부분) : false일 때 출력값(실행 부분)
        }

        public static bool IsAdmin()
        {
            return false;
        }
    }
}
