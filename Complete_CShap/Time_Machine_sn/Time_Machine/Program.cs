using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Develop an app which takes a date (birthday, marriage date for ex.) and it shall tell you which day of the week it was.");
            
            Console.WriteLine("\nEnter the day..");
            int day = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the month..");
            int month = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the year..");
            int year = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(year, month, day);
            
            Console.WriteLine("This day should be {0:dddd}", dt);
        }
    }
}
