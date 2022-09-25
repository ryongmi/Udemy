using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int serialno = 150;
            string accountno = "";
            float anyno = 3.3f;

            accountno = serialno.ToString();

            Console.WriteLine(accountno);

            serialno = Convert.ToInt32(anyno);

            Console.WriteLine(serialno);

            anyno = 3.6f;

            serialno = Convert.ToInt32(anyno);
            // 반올림되서 할당됨.
            
            // serialno = (int)anyno;
            // (int)로 형변환을 하면 반올림하지 않고 변환됨. (정수만 변환)

            Console.WriteLine(serialno);
        }
    }
}
