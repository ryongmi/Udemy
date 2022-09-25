using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValuePairApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();
            // Key, Value를 포함하는 클래스 ( 위에 처럼 사용하면 Dictionary를 사용하는 것 같은 효과 )
            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Sweden", "Stockholm"));
            capitals.Add(new KeyValuePair<string, string>("Portual", "Lisbon"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokoyo"));

            foreach (var item in capitals)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(GetFirstAndLastName());
        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Ahmad";
            string lastName = "Mohey";

            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }
}
