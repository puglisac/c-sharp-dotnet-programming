using System;

namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);

            Console.WriteLine(myTuple.Item2);

            var newTuple = Tuple.Create(2, "goodbye", false, 7);

            Console.WriteLine(newTuple.Item4);
            Console.WriteLine(newTuple.Item2);


        }
    }
}
