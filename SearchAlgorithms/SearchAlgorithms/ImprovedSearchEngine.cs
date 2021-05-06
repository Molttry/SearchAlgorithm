using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class ImprovedSearchEngine : ISearchEngine
    {
        public bool Search(int[] Array, int x)
        {
           for (int i=0; i < Array.Length; i++)
            {
                if (Array[i] == x)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
