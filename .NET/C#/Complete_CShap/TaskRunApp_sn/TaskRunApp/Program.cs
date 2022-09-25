using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHithod();

            AddNumbersTask(10, 12, 13, 45, 11);

            Console.ReadLine();
        }

        private static Task SayHithod()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hi there from the task");
            });
        }
        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started...");
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                Console.WriteLine("Total = " + result);
            });
        }
    }
}
