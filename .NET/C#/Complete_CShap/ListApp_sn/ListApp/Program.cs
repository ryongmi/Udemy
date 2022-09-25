using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>();
            // 제네릭 List, string으로 타입을 명시해 놓은 List.
            // 제네릭이 결국 타입을 명시하여 사용하는 것
            // ArrayList와 차이점은 List는 컴파일시 배열의 타입 추론을 하여 박싱, 언박싱이 발생하지 않는다.
            IList<string> secondList = new List<string>();

            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");
            
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            firstList[2] = "South Korea";
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count is " + firstList.Count);

            Console.WriteLine("After Sorting...");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Reversing...");
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("After Removing...");
            firstList.Remove("Germany");
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count is " + firstList.Count);

            Console.WriteLine("-----------------------");
            Console.WriteLine(firstList.Contains("South Korea"));

            secondList = firstList.GetRange(0, 2);
            // GetRange(0, 2) : 0~1번째 인덱스에 있는 값을 반환함 ( 0 <= x < 2 )
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
