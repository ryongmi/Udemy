using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncWithAnonymousAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ahmad Mohey";

            Func<string, string> ConvertToUppercase = UppercaseString;
            Console.WriteLine("using func ");
            Console.WriteLine(ConvertToUppercase(name));

            Func<string, string> anonymousMethod = delegate (string myName) { return myName.ToUpper(); };
            Console.WriteLine("using anonymous method ");
            Console.WriteLine(anonymousMethod(name));

            Func<string, string> lambdaExpression = text => text.ToUpper();
            Console.WriteLine("using lambda expression ");
            Console.WriteLine(lambdaExpression(name));
        }

        public static string UppercaseString(string inputString)
        {
            return inputString.ToUpper();
        }
    }
}
