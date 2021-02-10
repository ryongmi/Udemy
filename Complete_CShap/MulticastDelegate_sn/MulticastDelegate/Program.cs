using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void SayHiDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;
            // SayHiDelegate sayHi; 과 다른점?

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);
            sayHi += new SayHiDelegate(SayHiJapanese);
            sayHi += new SayHiDelegate(SayHiItalian);
            sayHi += new SayHiDelegate(SayHiGerman);
            sayHi += new SayHiDelegate(SayHiArabic);
            // 멀티 델리게이트 사용

            sayHi();
        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there.");
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola.");
        }

        public static void SayHiJapanese()
        {
            Console.WriteLine("Kon'nichiwa.");
        }

        public static void SayHiItalian()
        {
            Console.WriteLine("Ciao.");
        }

        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo.");
        }

        public static void SayHiArabic()
        {
            Console.WriteLine("Marhabaan.");
        }
    }
}
