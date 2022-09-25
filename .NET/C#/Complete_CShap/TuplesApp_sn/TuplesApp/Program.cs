using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Jack", "William", new DateTime(2017,10,15), true);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString());
            Console.WriteLine(empInfo.Item5);
            // Tuple에 있는 아이템값 반환, 앞에서부터 순서대로 1~n

            var studentInfo = Tuple.Create(5, "John", "Cavin", new DateTime(2003, 10, 27));
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4);
            //Tuple을 만들 수 있는 2가지 방법, 위에는 제네릭을 사용한 것 같음.

            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "James", "Watson", "", "", "", "", Tuple.Create(2000m, 3000m, 4000m, 5000m, 6000m));
            // Tuple안에 Tuple을 저장하는 법, 8번째는 Rest로 나와 있는데, 이곳에서만 Tuple을 사용할 수 있음.

            Console.WriteLine($"Employee name is {employeeInfo.Item2}");
            Console.WriteLine("Last 5 salaries");
            Console.WriteLine(employeeInfo.Rest.Item1);
            Console.WriteLine(employeeInfo.Rest.Item2);
            Console.WriteLine(employeeInfo.Rest.Item3);
            Console.WriteLine(employeeInfo.Rest.Item4);
            Console.WriteLine(employeeInfo.Rest.Item5);
            // Rest에 저장한 Tuple의 Item을 반환받기
        }
    }
}
