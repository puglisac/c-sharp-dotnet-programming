using System;
using System.Collections;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BitArray enemyGrid = new BitArray(3);
            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);

            bool[] preload = new bool[3] { false, true, true };
            BitArray enemyGrid2 = new BitArray(preload);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }
            foreach (var item in enemyGrid2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
