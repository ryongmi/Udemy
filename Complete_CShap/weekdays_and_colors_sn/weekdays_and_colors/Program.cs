using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekdays_and_colors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Develop an app which takes the today date and assign the color based on the below table using switch statement.");

            string days = Console.ReadLine();

            switch (days)
            {
                case "Saturday":
                    Console.WriteLine("Saturday: Yellow");
                    break;

                case "Sunday":
                    Console.WriteLine("Sunday: Green");
                    break;

                case "Monday":
                    Console.WriteLine("Monday: Blue");
                    break;

                case "Tuesday":
                    Console.WriteLine("Tuesday: Grey");
                    break;

                case "Wednesday":
                    Console.WriteLine("Wednesday: Red");
                    break;

                case "Thursday":
                    Console.WriteLine("Thursday: Orange");
                    break;

                case "Friday":
                    Console.WriteLine("Friday: White");
                    break;
            }
        }
    }
}
