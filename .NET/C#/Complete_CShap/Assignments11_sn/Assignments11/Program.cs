using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
add and remove methods for list of tuples

create a list of tuples of players

create an add method to add items to list passing to it the tuple values

create an overloaded add method to do the previous task but with an index to insert at

create a remove method to remove item at specific index at the list

*/


namespace Assignments11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string, int>> playersList = new List<Tuple<int, string, int>>();

            AddPlayer(Tuple.Create(7, "Ronaldo", 55), ref playersList);
            AddPlayer(Tuple.Create(17, "Rooney", 55), ref playersList);
            AddPlayer(Tuple.Create(10, "Messi", 55), ref playersList, 0);

            RemovePlayer(ref playersList, 1);

            foreach (var player in playersList)
            {
                Console.WriteLine($"{player.Item1}, {player.Item2}, {player.Item3}");
            }
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list)
        {
            list.Add(player);
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list, int index)
        {
            list.Insert(index, player);
        }

        public static void RemovePlayer(ref List<Tuple<int, string, int>> list, int index)
        {
            list.RemoveAt(index);
        }
    }
}
