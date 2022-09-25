using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameValueCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection cities = new NameValueCollection();
            // name, value 값을 가진 클래스, name 중복 가능, 같은 name값을 가진 value 검색하는 용도로 사용하기 적당함
            cities.Add("Germany", "berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "FrankFurt");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");
            
            foreach (string item in cities)
            {
                Console.WriteLine($"{item} : {cities[item]}");
                // item은 name값을 받아옴cities
                // 객체의 name을 검색하면 value값들을 불러올 수 있음
            }

            cities.Set("Italy", "Venice");
            // key값에 해당하는 value들을 전부 업데이트
            foreach (string item in cities)
            {
                Console.WriteLine($"{item} : {cities[item]}");
            }

            // cities.Clear();
            Console.WriteLine(cities.HasKeys());
            // HasKeys() : 객체에 Key가 들어 있는지 여부 확인 ( 있다면 True 반환 )

            cities.Remove("Germany");
            // Key 값에 해당하는 Key값을 전부 삭제
            foreach (string item in cities)
            {
                Console.WriteLine($"{item} : {cities[item]}");
            }
        }
    }
}
