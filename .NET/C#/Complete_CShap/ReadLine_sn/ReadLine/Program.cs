using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string user_name = Console.ReadLine();

            Console.WriteLine(user_name);
        }
    }
}
