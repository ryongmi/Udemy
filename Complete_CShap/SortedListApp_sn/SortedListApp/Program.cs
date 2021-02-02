using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace SortedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            // 해시테이블과 마찬가지로 Key값을 기준으로 자동 정렬됨

            sortedList.Add(10, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");
            // Key 값이 중복될 수 없음

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
                // GetKey(i) : i번째 인덱스의 Key값을 반환함.
                // GetByIndex(i) : i번째 인덱스의 Value값을 반환함.
            }

            Console.WriteLine(sortedList[10].ToString());
            // [x] : x와 같은 Key값의 Value값 반환

            Console.WriteLine(sortedList.Count);

            sortedList.RemoveAt(2);
            // 지정된 인덱스 삭제
            sortedList.Remove(2);
            // 지정된 Key값을 가진 인덱스 삭제

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("-----------------------");

            ArrayList arrayList = new ArrayList(sortedList.Keys);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
