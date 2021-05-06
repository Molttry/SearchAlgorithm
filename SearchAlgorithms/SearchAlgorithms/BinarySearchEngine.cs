using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class BinarySearchEngine : ISearchEngine
    {
        public bool Search(int[] Array, int x)
        {
            int step = 0;
            int min = 0;
            int max = Array.Length - 1;
            while (min <= max)
            {
                int mid = ((min + max) / 2);
                if (x == Array[mid] || x == Array[min] || x == Array[max])
                {
                    return true;
                }
                else if (x < Array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
                step++;
            }
            Steps(step);
            return false;

        }
        public int Steps (int count)
        {
            Console.WriteLine($"{count} steps");
            return count;
        }
    }
}
