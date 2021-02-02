using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            WeekDay day = WeekDay.Monday;
            Console.WriteLine(day.ToString() + " " + (int)day);
            WeekDay day2 = WeekDay.Tuesday;
            Console.WriteLine(day2.ToString() + " " + (int)day2);
        }
    }

    enum WeekDay
    {
        Monday,
        Tuesday = 50
        // 열거형 : 문자열과 정수형 값을 가져올 수 있음.
        // WeekDay는 enum형이기 때문에 Tostring()같은 형변환을 사용.
        // Monday -> Tostring()을 사용하면 반환됨. 0 -> (int) 형변환을 사용하면 반환됨, 기본적으로 인덱스 값을 반환함. 위에서부터 0~
        // Tuesday = 50 -> Tuesday의 인덱스 값을 50으로 설정함. (int) 형변환을 사용하면 50이 반환됨.
    }
}
