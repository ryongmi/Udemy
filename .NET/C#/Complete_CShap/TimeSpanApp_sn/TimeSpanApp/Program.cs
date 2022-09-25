using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(10, 50, 55);
            // TimeSpan : 시간을 표현할 수 있게 해주는 클래스, TimeSpan 객체간 연산(+, - 등) 가능, 60초, 60분, 24시간을 넘기면 자동으로 분, 시간, 일이 증가함
            // TimeSpan(25, 61, 60) -> 1.02:02:0   =>   1. 는 일(Day) 표시,   년, 월은 표현이 안되는것 같음
            Console.WriteLine(ts);

            ts = ts.Add(new TimeSpan(0, 0, 30));
            Console.WriteLine(ts);

            DateTime myDateOne = new DateTime(1999, 10, 30);
            DateTime myDateTwo = new DateTime(2017, 10, 30);

            TimeSpan sub = myDateTwo - myDateOne;
            // DateTime 객체간 연산을 하면 TimeSpan(일.시:분:초) 타입으로 변함.
            // sub = myDateTwo.Subtract(myDateOne); Two - One 연산 메서드, 괄호안에 있는 값으로 호출자를 감소시킴
            Console.WriteLine(sub.Days);
        }
    }
}
