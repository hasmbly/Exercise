using System.Collections.Concurrent;
using System.Diagnostics;

namespace Exercise.CommonCode.Parallelism
{
    internal static class Parallelism_01
    {
        public static void Run()
        {
            Console.WriteLine($"Starting..");

            // Static partitioning requires indexable source. Load balancing
            // can use any IEnumerable.
            var nums = Enumerable.Range(0, 5000).ToArray();

            // Create a load-balancing partitioner. Or specify false for static partitioning.
            Partitioner<int> customPartitioner = Partitioner.Create(nums, true);

            // The partitioner is the query's data source.
            var q = from x in customPartitioner.AsParallel()
                    select x * Math.PI;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            q.ForAll((x) =>
            {
                Console.WriteLine($"result: {x}");
            });

            stopwatch.Stop();
            Console.WriteLine($"Finished in {stopwatch.Elapsed.TotalSeconds} seconds", ConsoleColor.Green);
        }
    }
}
