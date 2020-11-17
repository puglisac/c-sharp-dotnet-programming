using System;
using System.Collections.Generic;

namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<string>();
            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");

            Console.WriteLine(customers.Count);

            foreach (var name in customers)
            {
                Console.WriteLine(name);
            }
        }
    }
}
