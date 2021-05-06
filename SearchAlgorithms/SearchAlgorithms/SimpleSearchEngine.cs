using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithms
{
    public class SimpleSearchEngine : ISearchEngine
    {
        public bool Search(int[] Array, int x)
        {
            int res = 0;
            for (int i=0; i<Array.Length; i++)
            {
                if (Array[i] == x)
                {
                    res = x;
                } 
            }
            GetX(x);
            return true;
        }
        private int GetX(int x)
        {
            return x;
        }
    }
}
