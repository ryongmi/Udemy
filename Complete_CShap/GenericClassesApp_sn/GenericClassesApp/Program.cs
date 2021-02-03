using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings<int> empireState = new Buildings<int>();
            // 제네릭 클래스, 객체를 생성할때 타입을 지정하여 매번 생성하고 싶은 다른 타입으로 사용할 수 있게해줌.
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;

            Console.WriteLine($"Name : {empireState.Name}");
            Console.WriteLine($"City : {empireState.City}");
            Console.WriteLine($"Height : {empireState.Height}");
            Console.WriteLine($"Weight : {empireState.Weight}");

            Buildings<double> burjkhalifa = new Buildings<double>();
            burjkhalifa.Name = "Burj Khalifa";
            burjkhalifa.City = "Dubai";
            burjkhalifa.Height = 830;
            burjkhalifa.Weight = 450000;

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Name : {burjkhalifa.Name}");
            Console.WriteLine($"City : {burjkhalifa.City}");
            Console.WriteLine($"Height : {burjkhalifa.Height}");
            Console.WriteLine($"Weight : {burjkhalifa.Weight}");

            Buildings<float> eiffelTower = new Buildings<float>();
            eiffelTower.Name = "Eiffel Tower";
            eiffelTower.City = "Paris";
            eiffelTower.Height = 324;
            eiffelTower.Weight = 7300;

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Name : {eiffelTower.Name}");
            Console.WriteLine($"City : {eiffelTower.City}");
            Console.WriteLine($"Height : {eiffelTower.Height}");
            Console.WriteLine($"Weight : {eiffelTower.Weight}");
        }
    }

    class Buildings<T>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;

        public T Height
        {
            get { return height; }
            set { height = value; }
        }

        private T weight;

        public T Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
