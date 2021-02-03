using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Ram = new Stack<string>();

            Ram.Push("Visual Studio");
            Ram.Push("Google Chrome");
            Ram.Push("Photoshop");
            Ram.Push("NotePad");

            Console.WriteLine(Ram.Peek());
            // 제일 위에 적재된 데이터를 반환함. ( 삭제 x )

            foreach (var item in Ram)
            {
                Console.WriteLine(item);
            }
        }
    }
}
