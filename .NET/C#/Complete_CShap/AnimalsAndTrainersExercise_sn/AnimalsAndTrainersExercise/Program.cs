using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndTrainersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals();
            dog.Name = "Max";

            Animals cat = new Animals();
            cat.Name = "Lucy";

            Animals elephant = new Animals();
            elephant.Name = "Fofy";

            Trainers john = new Trainers();
            john.TrainerName = "John Jackson";

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);
            list.Add(john);

            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else if (typeof(Trainers) == item.GetType())
                    ((Trainers)item).SayHi();
                // typeof(x) : x의 타입을 반환함
                // item.GetType : item의 타입을 반환함
            }
        }
    }

    struct Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello my name is " + name);
        }

        public void Feed()
        {
            Console.WriteLine(name + " is now eating");
        }
    }

    struct Trainers
    {
        private string trainerName;

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("Hello I am the new trainer");
        }
    }
}
