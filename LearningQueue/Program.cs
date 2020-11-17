using System;
using System.Collections.Generic;

namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Count);
        }
    }
}
