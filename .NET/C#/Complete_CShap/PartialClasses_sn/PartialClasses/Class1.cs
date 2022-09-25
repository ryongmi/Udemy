using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    partial class Animals
    {
        public string animalColor;
        public string animalBreed;

        public void GetName()
        {
            Console.WriteLine("My name is max, I am a dog");
        }
    }
}
