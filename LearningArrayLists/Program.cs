using System;
using System.Collections;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // array list stores any type by boxing. converts into c# object
            ArrayList list = new ArrayList();
            list.Add("some string");

            //need to unbox and cast back into string to have access to string properites.
            string s = (string)list[0];

            Console.WriteLine(s.Length);
        }
    }
}
