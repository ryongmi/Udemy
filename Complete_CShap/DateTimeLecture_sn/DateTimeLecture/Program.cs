using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(1999,10,5);
            Console.WriteLine(myDate);

            DateTime myDate2 = new DateTime(1999, 10, 5, 12, 50, 30);
            Console.WriteLine(myDate2);

            DateTime myDate3 = DateTime.Today;
            Console.WriteLine(myDate3);

            DateTime myDate4 = DateTime.Now;
            Console.WriteLine(myDate4);

            DateTime myDate5 = DateTime.Now;
            Console.WriteLine(myDate5.ToShortTimeString());
            // ToShortTimeString() : 오후(오전) 시간:분을 반환하는 메서드

            Console.WriteLine(myDate5.ToShortDateString());
            // ToShortDateString() : 년-월-일을 반환하는 메서드
            
            Console.WriteLine(myDate5.ToLongDateString());
            // ToShortDateString() : xxxx년 xx월 xx일 x요일을 반환하는 메서드

            Console.WriteLine(myDate5.ToLongTimeString());
            // ToShortDateString() : 오후(오전) 시:분:초를 반환하는 메서드

            string formattedDate = string.Format("Date is {0:yyyy MM dd HH mm ss tt}", myDate5);
            // {0:yyyy MM dd} : DateTime 객체 myDate5의 년,월,일을 가져오는 정규식
            Console.WriteLine(formattedDate);
        }
    }
}
