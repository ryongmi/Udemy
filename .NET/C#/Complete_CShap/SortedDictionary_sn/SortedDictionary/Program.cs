using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> colors = new SortedDictionary<int, string>();
            // 키값을 기준으로 자동으로 정렬되는 Dictionary
            colors.Add(4, "Blue");
            colors.Add(2, "Yellow");
            colors.Add(1, "Orange");
            colors.Add(5, "Black");
            colors.Add(3, "White");

            Console.WriteLine($"1번째 인덱스 : {colors.ElementAt(1)}");
            // 인덱스 번호로 Value를 불러오는 방법
            Console.WriteLine("--------------------");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
