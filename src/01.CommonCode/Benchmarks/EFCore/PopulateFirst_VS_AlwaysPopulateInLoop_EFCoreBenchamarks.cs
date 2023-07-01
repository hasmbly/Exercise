using BenchmarkDotNet.Attributes;
using Exercise.CommonCode.Model;
using Microsoft.EntityFrameworkCore;

namespace Exercise.CommonCode.Benchmarks.EFCore
{
    [MemoryDiagnoser(false)]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class PopulateFirst_VS_AlwaysPopulateInLoop_EFCoreBenchamarks
    {
        public List<int> Parameters { get; set; } = new() { 1, 2, 3, 4, 5, 6, 7 };

        private AdventureWorks2019Context _adventureWorks2019Context { get; set; } = new();

        public PopulateFirst_VS_AlwaysPopulateInLoop_EFCoreBenchamarks()
        {
            _adventureWorks2019Context = new AdventureWorks2019Context();
        }

        [Benchmark]
        public void PopulateFirst()
        {
            var results = new List<SalesOrderHeader>();

            var salesOrderHeaders = _adventureWorks2019Context.SalesOrderHeaders
                .AsNoTracking()
                .Where(x => Parameters.Contains((int)x.TerritoryId!))
                .ToList();

            foreach (var parameter in Parameters)
            {
                var salesOrderHeader = salesOrderHeaders
                    .Where(x => x.TerritoryId == parameter)
                    .FirstOrDefault();

                if (salesOrderHeader is not null)
                {
                    results.Add(salesOrderHeader);
                }
            }

            Console.WriteLine($"Result: {results.Count}");
        }

        [Benchmark]
        public void AlwaysPopulateInLoops()
        {
            var results = new List<SalesOrderHeader>();

            foreach (var parameter in Parameters)
            {
                var salesOrderHeader = _adventureWorks2019Context.SalesOrderHeaders
                    .AsNoTracking()
                    .Where(x => x.TerritoryId == parameter)
                    .FirstOrDefault();

                if (salesOrderHeader is not null)
                {
                    results.Add(salesOrderHeader);
                }
            }

            Console.WriteLine($"Result: {results.Count}");
        }
    }
}