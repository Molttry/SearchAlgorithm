using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ISearchEngine engine = GetSearchEngine();
            Measure(engine);
        }

        static ISearchEngine GetSearchEngine()
        {
            Console.WriteLine("select mode: SIMPLE(sim), IMPROVED(imp), IMPROVED WITH SENTINEL(imps) or BINARY(bin)");
            string mode = Console.ReadLine();
            switch (mode)
            {
                case "sim":
                    return new SimpleSearchEngine();
                case "imp":
                    return new ImprovedSearchEngine();
                case "imps":
                    return new ImprovedWithSentinelSearchEngine();
                case "bin":
                    return new BinarySearchEngine();
                default:
                    Console.WriteLine("No mode chosen, closing");
                    return null;
            }
        }

        static void Measure(ISearchEngine engine)
        {
            int[] Array1 = CreateArray(100000000);
            int bestCase = Array1[0];
            int worstCase = -1;
            long bestCaseTime;
            long worstCaseTime;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            engine.Search(Array1, bestCase);
            watch.Stop();
            bestCaseTime = watch.ElapsedMilliseconds;
            watch.Reset();
            watch.Start();
            engine.Search(Array1, worstCase);
            watch.Stop();
            worstCaseTime = watch.ElapsedMilliseconds;
            Console.WriteLine($"Best case: {bestCaseTime}ms,\nWorst case: {worstCaseTime}ms");
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
            return array;
        }
        static void Filling(int[] Array)
        {
            Random rd = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rd.Next(7, 101);
            }
        }
    }
}
