using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2000, 11, 1);
            Console.WriteLine(myDate.MyCustomFormat());
        }
    }

    static class MyExtensions
    {
        public static string MyCustomFormat(this DateTime date)
        // 매개변수 this는 함수 호출시 객체에서 메서드 호출하는 것처럼 "변수.함수"로 호출이 가능함. 여기서 변수가 매개변수 date가 된다.
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}", date);
        }
    }
}
