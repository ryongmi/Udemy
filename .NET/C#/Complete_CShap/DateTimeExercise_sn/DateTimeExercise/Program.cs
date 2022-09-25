using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2017, 09, 30, 01, 15, 55);

            string formattedDate = "";
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}", dt);

            Console.WriteLine("First Format : " + formattedDate);
            // First Format : 30-09-2017 01:15:55

            // formattedDate = string.Format("{0:dddd} of month {0:MMMM yyyy}", dt);
            formattedDate = string.Format("{0:dddd 'of month' MMMM yyyy}", dt);
            // '' 안에 있는 문자는 그대로 출력함
            Console.WriteLine("Second Format : " + formattedDate);
            // Second Format : Saturday of month September 2017

            //Console.WriteLine("Third Format");
            //Console.WriteLine("Day {0:dddd}", dt);
            //Console.WriteLine("Month {0:MMMM}", dt);
            //Console.WriteLine("Year {0:yyyy}", dt);

            formattedDate = string.Format("{0:'Day' dddd \n'Month' MMMM \n'Year' yyyy}", dt);
            Console.WriteLine("Third Format \n" + formattedDate);

            /*
            Third Format
            Day Saturday
            Month September
            Year 2017
             */
        }
    }
}
