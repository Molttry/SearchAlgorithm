using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class ImprovedWithSentinelSearchEngine : ISearchEngine 
    {
        public bool Search(int[] Array, int x)
        {
            int i = 0;
            Array[Array.Length-1] = x;
            while(Array[i]!= x)
            {
                i++;
            }
            return true;
        }
    }
}
