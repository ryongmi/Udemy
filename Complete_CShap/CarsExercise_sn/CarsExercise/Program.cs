using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfo();
        }
    }

    #region Cars - This is the solution for the car exercise
    class Cars
    {
        #region Variables - This is where you should declare your variables
        private decimal price;
        protected int maxSpeed;
        public string color;
        #endregion

        protected decimal Price { get; set; }

        public virtual void DisplayInfo()
        {
            price = 10000;
            maxSpeed = 300;
            color = "Black";

            Console.WriteLine($"Default values : price is {price}, max speed is {maxSpeed} and the color is {color}");
        }
    }

    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.Price = 15000;
            base.maxSpeed = 200;
            base.color = "blue";

            Console.WriteLine($"Default values : price is {Price}, max speed is {maxSpeed} and the color is {color}");
        }
    }
    #endregion
}
