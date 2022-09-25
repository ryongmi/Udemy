using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList(); // non generic sortedlist
            SortedList<string, string> phoneBook = new SortedList<string, string>(); // generic sortedlist

            phoneBook.Add("Jack", "823456789");
            phoneBook.Add("Willy", "944456789");
            phoneBook.Add("Charles", "123456789");
            phoneBook.Add("Jennifer", "623456789");
            // 키 값 기준으로 자동 정렬됨

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + ", the mobile no is " + item.Value);
            }

            phoneBook["Jack"] = "123456789";
            Console.WriteLine(phoneBook["Jack"]);

            phoneBook.TryGetValue("Jack", out string number);
            if(number != null)
                Console.WriteLine(number);
        }
    }
}
