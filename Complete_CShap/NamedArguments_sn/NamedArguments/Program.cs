using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPlayerInformation(playerGoals: 55, playerName: "Roanldo", playerNo: 7, country: "Protugal");
            // 명명된 인수 : 인수를 함수의 매개변수명과 같은 명으로 명시하여 할당하는 것, 매개변수 순서에 상관없이 넣을 수 있는 장점이 있다.
        }

        public static void DisplayPlayerInformation(int playerNo, string playerName, int playerGoals, string country = "Unknown")
        {
            Console.WriteLine(playerNo);
            Console.WriteLine(playerName);
            Console.WriteLine(playerGoals);
            Console.WriteLine(country);
        }
    }
}
