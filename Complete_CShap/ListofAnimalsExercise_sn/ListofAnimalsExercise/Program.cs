using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListofAnimalsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Gindokkae";
            Animals cat = new Animals();
            cat.Name = "Nabi";
            Animals elephant = new Animals();
            elephant.Name = "Foni";

            List<Animals> list = new List<Animals>();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);

            foreach (var item in list)
            {
                item.SayHi();
            }
        }
    }

    class Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello my name is {name}");
        }

        public void Feed()
        {
            Console.WriteLine($"{name} is now eating");
        }
    }
}
