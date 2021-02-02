using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = true;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;
            BitArray secondArray = new BitArray(boolArray);

            BitArray firstArray = new BitArray(4);
            firstArray.Set(0, true);
            firstArray.Set(1, false);
            firstArray.Set(2, true);
            firstArray.Set(3, true);

            /*
             * bool 배열을 만들 2가지 방법
             */

            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }

            BitArray result = new BitArray(4);
            //result = firstArray.And(secondArray);
            //Console.WriteLine("And");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //result = firstArray.Or(secondArray);
            //Console.WriteLine("Or");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            result = firstArray.Not();
            Console.WriteLine("Not");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
