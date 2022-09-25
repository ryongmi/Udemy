using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> condition = IsAdmin;
            Console.WriteLine(condition(11));
        }

        public static bool IsAdmin(int empNo)
        {
            if (empNo == 10)
                return true;
            else
                return false;
        }
    }
}
