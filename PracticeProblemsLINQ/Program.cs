﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> result1 = LinqProblems.RunProblem1(words);
            Console.WriteLine(result1);


            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> result2 = LinqProblems.RunProblem2(names);
            Console.WriteLine(result2);
            Console.ReadLine();

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };

            Customer result3 = LinqProblems.RunProblem3(customers);
            Customer result4 = LinqProblems.RunProblem4(customers);
            Console.WriteLine(result3.FirstName);
            Console.WriteLine(result4);
            Console.ReadLine();

            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };


            //--------------------
            //Bonus Problem 1
            string letters = "terrill";

        }
    }
}
