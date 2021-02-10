﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaWithGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5); list.Add(8); list.Add(6); list.Add(15);
            list.Add(7); list.Add(2); list.Add(1); list.Add(12);

            var oddList = list.Where(n => n % 2 != 0);
            var evenList = list.Where(n => n % 2 == 0);
            // Where() 메서드 : ()안의 조건에 맞는 값을 반환

            Console.WriteLine("Odd Numbers");
            foreach (var item in oddList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Even Numbers");
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
