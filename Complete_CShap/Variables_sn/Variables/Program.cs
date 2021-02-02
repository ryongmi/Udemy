using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Nuber x is " + x);
            x = 5;
            Console.WriteLine("Nuber x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 4.5f;
            decimal_num = 100.250m;

            Console.WriteLine(double_num);
            Console.WriteLine(float_num);
            Console.WriteLine(decimal_num);

            string firstname = "KIM";
            string lastname = "TW";

            Console.WriteLine("Hello, " + firstname + " " + lastname);

            bool isworking;

            isworking = true;

            Console.Write(isworking);
            // Write : 줄넘김이 없음

            Console.ReadLine();
        }
    }
}
