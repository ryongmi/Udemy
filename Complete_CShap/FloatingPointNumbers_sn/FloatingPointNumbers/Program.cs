﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float f_no = 0.0f;      // 4byte
            double d_no = 0.0d;     // 8byte
            decimal m_no = 0.0m;    // 16byte

            f_no = 1 / 3f;
            d_no = 1 / 3d;
            m_no = 1 / 3m;

            Console.WriteLine("Float no. is {0}", f_no);
            Console.WriteLine("Double no. is {0}", d_no);
            Console.WriteLine("Decimal no. is {0}", m_no);
        }
    }
}
