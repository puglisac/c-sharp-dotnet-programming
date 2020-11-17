using System;
using System.Collections;
using System.Collections.Generic;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pancakes = new Stack<string>();

            pancakes.Push("First");
            pancakes.Push("Second");
            pancakes.Push("Third");

            foreach (var item in pancakes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(pancakes.Pop());
            Console.WriteLine(pancakes.Peek());
            Console.WriteLine(pancakes.Count);
        }
    }
}
