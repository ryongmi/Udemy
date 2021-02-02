using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";

            Console.WriteLine("Hello, Dear Guest, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomGuest();
            else
                WelcomGuest(guestName);
        }

        static void WelcomGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy staying at our hotel");
        }

        static void WelcomGuest(string name)
        {
            Console.WriteLine($"Thank you {name}, we hope you enjoy staying at our hotel");
        }
    }
}
