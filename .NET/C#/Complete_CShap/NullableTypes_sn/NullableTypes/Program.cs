using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? myDate = null;
            // 데이터타입? (int?) : null 값을 허용하며, 기본 Default 값은 null로 지정됨.
            Console.WriteLine(myDate);

            int? number = null;
            Console.WriteLine(number);
            number = 5;

            int? numberTwo = null;

            Console.WriteLine(numberTwo ?? number);
            // ?? : null 병합연산자, (A ?? B) => A가 NULL이 아니라면 A값을 반환하고(이때, B값은 검토하지 않는다. A가 NULL이 아닌것을 안 순간 반환시작), A가 NULL이라면 B값을 반환함. A, B 둘다 NULL이면 NULL반환
            // C# 8.0 이상에서는 ??= 연산자를 사용할 수 있는데, A가 NULL이 아니라면 A값을 반환하고, A가 NULL이라면 A에 B를 할당하고 A값을 반환함.

            string firstName = null;
            // firstName = "John";

            string message = null;
            message = "first name is null";

            Console.WriteLine(firstName ?? message);
        }
    }
}
