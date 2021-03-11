using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Array2D = new string[3, 2];
            Array2D[0, 0] = "Item 00";
            Array2D[0, 1] = "Item 01";

            Array2D[1, 0] = "Item 10";
            Array2D[1, 1] = "Item 11";

            Array2D[2, 0] = "Item 20";
            Array2D[2, 1] = "Item 21";

            int[,] Array2DA = new int[4, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };
            string[,] NumbersArray = new string[,] { { "One", "Two" }, { "Three", "Four" }, { "Five", "Six" }, { "Seven", "Eight" }, { "Nine", "Ten" } };

            Console.WriteLine();
        }
    }
}
