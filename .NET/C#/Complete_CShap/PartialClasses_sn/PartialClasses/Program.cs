using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            animal.GetName();
            animal.GetDate();
            animal.animalName = "nabi";
            animal.animalBreed = "Th";
        }
    }
}
