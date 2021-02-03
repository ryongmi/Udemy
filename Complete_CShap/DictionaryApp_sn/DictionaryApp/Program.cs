using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            Dictionary<int, string> name = new Dictionary<int, string>()
            {
                { 1, "James"},
                { 2, "Jack"},
                { 3, "Emma"}
                // 초기화
            };
            
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");

            //foreach (var item in capitals)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals.Keys.ElementAt(i));

                //Console.WriteLine(capitals.Values.ElementAt(i));
                //Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
                //Console.WriteLine(capitals["Spain"]);
                // value를 반환받을 수 있는 3가지 방법
            }

            Console.WriteLine("----------------");
            capitals["Italy"] = "Venice";
            Console.WriteLine($"Italy is {capitals["Italy"]}");

            capitals.TryGetValue("Russia", out string result);
            if(result != null)
                Console.WriteLine("Result is " + result);

            Console.WriteLine("----------------");
            Console.WriteLine("After removing");
            capitals.Remove("Italy");
            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Capital is Count : {capitals.Count}");

            Console.WriteLine(capitals.ContainsKey("Italy"));
        }
    }
}
