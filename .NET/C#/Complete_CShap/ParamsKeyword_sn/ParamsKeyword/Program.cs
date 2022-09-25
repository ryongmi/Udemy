using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopThroughArray("Jack", "Tiffany", "Sandra", "Charles");
            Console.WriteLine("----------------");
            LoopThroughArray("Ahmad", "Mark", "Thomas", "Emma", "Jack", "Tom");
        }

        public static void LoopThroughArray(params string[] names)
        // params : 가변개수의 배열 매개변수 사용 가능하게 해주는 키워드
        // 1차원 배열이여야 하며, 타입이 지정이 되야 하며(object도 가능), 인수가 없어도 에러가 발생하지 않으며, 추가 매개변수는 허용하지 않는다(params 매개변수 하나만 가능). 
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
