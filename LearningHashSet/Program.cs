using System;
using System.Collections.Generic;

namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHash = new HashSet<string>();
            myHash.Add("hello");
            myHash.Add("hello");

            var myArray = new String[] { "hello", "Goodbye" };

            Console.WriteLine(myHash.Count);
            Console.WriteLine(myHash.Overlaps(myArray));
        }
    }
}
