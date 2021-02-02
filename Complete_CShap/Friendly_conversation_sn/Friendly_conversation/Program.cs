using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you "+name+" My name is C#, How old are you?");
            int year = int.Parse(Console.ReadLine());
            int now_year = DateTime.Now.Year;
            Console.WriteLine(year + " good, As for me I was born on 2002 which makes me "+ (now_year - 2002) +" years old");
        }
    }
}
