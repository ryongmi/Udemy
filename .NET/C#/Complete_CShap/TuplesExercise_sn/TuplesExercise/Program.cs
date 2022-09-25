using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, string, string, DateTime>> employeesInformation = new List<Tuple<int, string, string, DateTime>>();
            employeesInformation.Add(new Tuple<int, string, string, DateTime>(3, "Zack", "Peter", new DateTime(2017, 11, 25)));
            employeesInformation.Add(Tuple.Create(1, "Adam", "Green", new DateTime(2015, 01, 01)));
            employeesInformation.Add(Tuple.Create(4, "John", "Smith", new DateTime(2016, 10, 25)));
            employeesInformation.Add(Tuple.Create(2, "Emma", "Watson", new DateTime(2017, 01, 01)));

            Console.WriteLine("Before Sorting");
            foreach (var emplyee in employeesInformation)
            {
                Console.WriteLine($"{emplyee.Item1},{emplyee.Item2},{emplyee.Item3},{emplyee.Item4}");
            }

            employeesInformation.Sort();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("After Sorting");
            foreach (var emplyee in employeesInformation)
            {
                Console.WriteLine($"{emplyee.Item1},{emplyee.Item2},{emplyee.Item3},{emplyee.Item4}");
            }

            employeesInformation.Reverse();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("After Reversing");
            foreach (var emplyee in employeesInformation)
            {
                Console.WriteLine($"{emplyee.Item1},{emplyee.Item2},{emplyee.Item3},{emplyee.Item4}");
            }
        }
    }
}
