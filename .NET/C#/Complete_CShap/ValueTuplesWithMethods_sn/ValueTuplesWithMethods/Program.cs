using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuplesWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // ValueTuple 매개변수 및 함수 반환 사용하는 법
            var ronaldo = (7, "Ronaldo", 60);
            var giggs = (10, "Giggs", 40);

            DisplayPlayerInformation(ronaldo);
            DisplayPlayerInformation(giggs);
            DisplayPlayerInformation(DisplayPlayerInformation());
            // 다형성, 오버로딩 사용
        }

        // ValueTuple 매개변수 사용
        public static void DisplayPlayerInformation((int playerNo, string playerName, int playerGoal) player)
        {
            Console.WriteLine(player.playerNo);
            Console.WriteLine(player.playerName);
            Console.WriteLine(player.playerGoal);
            Console.WriteLine("--------------------");
        }

        // ValueTuple 반환
        public static (int, string, int) DisplayPlayerInformation()
        {
            var messi = (10, "Messi", 60);
            return messi;
        }
    }
}
