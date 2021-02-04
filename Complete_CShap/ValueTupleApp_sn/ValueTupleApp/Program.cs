using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Install-Package "System.ValueTuple"
            // ValueTuple은 Tuple과 다르게 클래스가 아닌 구조체, 참조형식이 아닌 값형식이며, 데이터 타입을 명시하지 않아도 사용 가능, 데이터 값이 바뀔수 있음
            
            (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
            // Item명을 지정하여 호출할때 명칭으로 호출가능함

            Console.WriteLine(ronaldo.playerNo);
            // Console.WriteLine(ronaldo.Item1);
            Console.WriteLine(ronaldo.playerName);
            Console.WriteLine(ronaldo.playerGoals);
            Console.WriteLine();

            var messi = (playerNo:10, playerName:"Messi", playerGoals:60);
            Console.WriteLine(messi.playerNo);
            Console.WriteLine(messi.playerName);
            Console.WriteLine(messi.playerGoals);
            Console.WriteLine();
        }
    }
}
