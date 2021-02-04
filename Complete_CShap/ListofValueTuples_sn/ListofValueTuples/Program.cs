using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofPlayers = new List<(int playerNo, string playerName, int playerGoals)>();

            listofPlayers.Add((7, "Ronaldo", 55));
            listofPlayers.Add((10, "Rooney", 45));
            listofPlayers.Add((20, "Neymar", 47));
            listofPlayers.Add((10, "Messi", 55));

            foreach (var player in listofPlayers)
            {
                Console.WriteLine($"{player.playerNo} - {player.playerName} - {player.playerGoals}");
                Console.WriteLine("------------------------------------------");
            }

            listofPlayers.Sort();
            Console.WriteLine("\nAfter Sorting");
            foreach (var player in listofPlayers)
            {
                Console.WriteLine($"{player.playerNo} - {player.playerName} - {player.playerGoals}");
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
