﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Game of Thrones    ";
            string seasonOne = " - Season 1";
            string newName = "";

            newName = tvShow.Insert(tvShow.Trim().Length, seasonOne);

            Console.WriteLine(newName);
        }
    }
}
