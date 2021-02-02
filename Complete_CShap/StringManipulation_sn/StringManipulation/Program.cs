using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "     lord of the RINGS     ";

            Console.WriteLine(movieName[17]);

            Console.WriteLine(movieName.Trim());
            // Trim : 선, 후 공백제거

            Console.WriteLine(movieName.ToUpper().Trim());
            // ToUpper : 문자열 대문자로 변경

            Console.WriteLine(movieName.ToLower().Trim());
            // ToLower : 문자열 소문자로 변경

            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);
            // Length : 문자열 길이 반환

            Console.WriteLine(movieName.Replace('l', 'L').Trim());
            // Replace : 문자 변경 메서드

            Console.WriteLine(movieName.IndexOf('o'));
            // IndexOf : 앞에서부터 문자를 검색하여 인덱스 번호 반환

            Console.WriteLine(movieName.LastIndexOf('o'));
            // LastIndexOf : 뒤에서부터 문자를 검색하여 인덱스 번호 반환

            Console.WriteLine(movieName.Substring(8, 5));
            // Substring : 8번째 문자 이후부터 5문자 반환

            Console.WriteLine(movieName.Remove(8));
            // Remove : 8번째 문자까지만 반환, 나머지 삭제

            Console.WriteLine(movieName.Insert(2, "Hi"));
            // Insert : 2번째에 HI를 삽입
        }
    }
}
