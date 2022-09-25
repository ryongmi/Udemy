using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionWithAnonymousAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jack";

            Action<string> Message = ShowMessage;
            Message(name);

            name = "Dog";
            Action<string> anonymousMethod = delegate (string myName) { Console.WriteLine($"Hi, how are you today, {myName}?"); };
            anonymousMethod(name);

            name = "Cat";
            Action<string> labmdaExpression = myName => Console.WriteLine($"Hi, how are you today, {myName}?");
            labmdaExpression(name);
        }

        public static void ShowMessage(string name)
        {
            Console.WriteLine($"Hi, how are you today, {name}?");
        }
    }
}
