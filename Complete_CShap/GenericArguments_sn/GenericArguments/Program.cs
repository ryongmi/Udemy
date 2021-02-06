using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInfo<string>("Generic");
            DisplayInfo<int>(1);
            DisplayInfo<decimal>(1.5m);
            // Generic 함수 호출
            
            DisplayInfo(1);
            // <int>를 명시하지 않고도 사용가능

            var playerInfo = (7, "Ronaldo", 55);
            DisplayInfo(playerInfo);
        }

        public static void DisplayInfo<T>(T info)
        // Generic 함수 정의
        {
            Console.WriteLine(info);
        }
    }
}
