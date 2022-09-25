using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeNavigationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars bmwM3 = new Cars();
            bmwM3.Brand = "BMW";
            bmwM3.Model = "M3";
            bmwM3.Price = 60_000;

            Cars mercedesAmgGt = new Cars();
            mercedesAmgGt.Brand = "Mercedes";
            mercedesAmgGt.Model = "AMG GT";
            mercedesAmgGt.Price = 150_000;

            Cars porscheCarreraGT = new Cars();
            porscheCarreraGT.Brand = "Porsche";
            porscheCarreraGT.Model = "Carrera GT";
            porscheCarreraGT.Price = 500_000;

            Cars ferrariEnzo = new Cars();
            ferrariEnzo.Brand = "Ferrari";
            ferrariEnzo.Model = "Enzo";
            ferrariEnzo.Price = 2_500_000;

            Console.WriteLine("Car Information");
            Cars.DisplayCarDetails(bmwM3);
            Cars.DisplayCarDetails(porscheCarreraGT);
            Cars.DisplayCarDetails(mercedesAmgGt);
            Cars.DisplayCarDetails(ferrariEnzo);


            List<Cars> listofCars = new List<Cars>();
            //List<Cars> listofCars = null;
            listofCars.Add(bmwM3);
            listofCars.Add(mercedesAmgGt);
            listofCars.Add(porscheCarreraGT);
            listofCars.Add(ferrariEnzo);

            int? count = 0;
            count = listofCars?.Count;
            // ?. : NULL 조건부 연산자, List 객체 listofCars가 null이기 때문에 조건부 연산자를 사용하지 않으면 오류가 발생, listofCars가 null이기 때문에 null 반환
            // null이 아니라면 count 실행
            Console.WriteLine(count);
        }
    }

    class Cars
    {
        private string carBrand;
        private string carModel;
        private decimal carPrice;

        public string Model
        {
            get => carModel;
            set => carModel = value;
        }
        public string Brand
        {
            get => carBrand;
            set => carBrand = value;
        }
        public decimal Price
        {
            get => carPrice;
            set => carPrice = value;
        }

        public static void DisplayCarDetails(Cars car)
        {
            //if (car.carBrand != null)
            //    Console.WriteLine(car.carBrand);
            //if (car.carModel != null)
            //    Console.WriteLine(car.carModel);
            //if (car.Price != null)
            //    Console.WriteLine(car.Price);

            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.carModel);
            Console.WriteLine(car?.Price);
            // ?. : NULL 조건부 연산자, car?.Brand => car가 NULL이라면 NULL 반환, car가 NULL이 아니라면 Brand를 반환

            Console.WriteLine("--------------");
        }
    }
}
