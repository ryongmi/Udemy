using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            // 해시테이블에 값들을 저장하면 자동으로 키값으로 정렬되어 저장됨
            
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Mercedes", "Germany");
            // Add("Key", "Value"), Key와 Value 모두 object 타입이기 때문에 어떤 값이든 들어감
            // Key 값이 중복될 수 없음

            foreach (DictionaryEntry item in hash)
            // DictionaryEntry : 키와 값을 선택할 수 있는 타입
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("Count: " + hash.Count);

            Console.WriteLine("------------------------");
            Console.WriteLine("After Removing");

            hash.Remove("Microsoft");
            // Remove("Key");

            foreach (DictionaryEntry item in hash)
            // DictionaryEntry : 키와 값을 선택할 수 있는 타입
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Contains condition");
            if(hash.Contains("Sony"))
            // Contains("Key") : 키 값을 가지고 있는지 확인하는 메서드, 가지고 있다면 True 반환
            // ContainsKey("Key") : 키 값을 확인하는 또 하나의 메서드.
                Console.WriteLine("Yes the collection has sony");
            else
                Console.WriteLine("No it does not have it");

            Console.WriteLine("------------------------");
            Console.WriteLine("Contains condition");
            if (hash.ContainsValue("Japan"))
                // ContainsValue("Value") : 값을 가지고 있는지 확인하는 메서드, 가지고 있다면 True 반환
                Console.WriteLine("Yes Japan is included");
            else
                Console.WriteLine("No it is not");

            Console.WriteLine("------------------------");
            Console.WriteLine("After copying");
            ArrayList array = new ArrayList(hash.Values);
            // 배열에 해시테이블 값을 넣는 방법. hash의 값을 넣었지만, (hash.Key)로 Key값도 넣을 수 있다. ( ArrayList에는 하나의 값만 들어가기때문에 키나 값을 넣는다 )

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
