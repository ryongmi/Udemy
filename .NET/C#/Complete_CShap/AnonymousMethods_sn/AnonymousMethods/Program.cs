using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    delegate void DisplayInfo();
    delegate void DisplayInfoBasedOnNumber(int number);

    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo normalDelegate = new DisplayInfo(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumber oneParameterDelegate = new DisplayInfoBasedOnNumber(GetInformation);
            oneParameterDelegate(100);

            Console.WriteLine("-----------------------");

            DisplayInfo normalDelegateAnonymous = delegate { Console.WriteLine("Hi from the anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumber oneParameterDelegateAnonymous = delegate (int x) { Console.WriteLine("Hi from the anonymous method which takes one int parameter " + x); };
            oneParameterDelegateAnonymous(150);
            // Delegate 참조할 때, delegate 메서드를 만들어서 참조 가능
        }

        public static void GetInformation()
        {
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            Console.WriteLine("Delegate with no parameter" + x);
        }
    }
}
