using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = int.MaxValue;
            // int.MaxValue : int의 최대값

            Console.WriteLine(x);

            int y = int.MinValue;
            // int.MinValue : int의 최소값

            Console.WriteLine(y);

            uint z = uint.MaxValue;
            // u를 붙이면 음수를 제외한 0~최대값(최대값은 음수를 제외했기 때문에 int보다 최대값이 늘어남.)
            
            Console.WriteLine(z);

            Console.WriteLine(typeof(int));
        }
    }
}
