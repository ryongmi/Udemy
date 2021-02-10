using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcOne = AddTwoNumbers;
            // 함수 델리게이트 : Generic <>으로 정의한 개수만큼(마지막 1개는 제외, 반환 데이터 타입) 매개변수를 사용, 델리게이트와 똑같이 메서드 참조하여 사용
            // int 타입의 반환값을 받음.
            Console.WriteLine(AddTwoNumbers(3, 10));

            Func<int> funcTwo = AddTwoNumbers;
            Console.WriteLine(funcTwo());
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int AddTwoNumbers()
        {
            int z = 0;
            int x = 5;
            int y = 2;

            z = x + y;

            return z;
        }
    }
}
