using System;
using System.Collections;

namespace LearningHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("title", "MyWebsite");

            string s = (string)table["title"];
            Console.WriteLine(s);
        }
    }
}
