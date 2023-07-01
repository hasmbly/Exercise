using BenchmarkDotNet.Attributes;
using Exercise.CommonCode.Model;
using Microsoft.EntityFrameworkCore;

namespace Exercise.CommonCode.Benchmarks.EFCore
{
    [MemoryDiagnoser(false)]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class IncludeOrSelect_EFCoreBenchmarks
    {
        [Params(100, 1000)]
        public int PageSize { get; set; }

        private AdventureWorks2019Context _adventureWorks2019Context { get; set; } = new();

        public IncludeOrSelect_EFCoreBenchmarks()
        {
            _adventureWorks2019Context = new AdventureWorks2019Context();
        }

        [Benchmark]
        public void RunWithInclude()
        {
            var salesOrderHeaders = _adventureWorks2019Context.SalesOrderHeaders
                .AsNoTracking()
                .Include(a => a.SalesOrderDetails)
                .Take(PageSize)
                .ToList();

            var results = new List<SalesOrderHeader>();

            foreach (var salesOrderHeader in salesOrderHeaders)
            {
                results.Add(salesOrderHeader);
            }
        }

        [Benchmark]
        public void RunWithIncludeWithoutAsNoTracking()
        {
            var salesOrderHeaders = _adventureWorks2019Context.SalesOrderHeaders
                .Include(a => a.SalesOrderDetails)
                .Take(PageSize)
                .ToList();

            var results = new List<SalesOrderHeader>();

            foreach (var salesOrderHeader in salesOrderHeaders)
            {
                results.Add(salesOrderHeader);
            }
        }

        [Benchmark]
        public void RunWithoutInclude()
        {
            var salesOrderHeaders = _adventureWorks2019Context.SalesOrderHeaders
                .AsNoTracking()
                .Select(x => new SalesOrderHeader 
                { 
                    SalesOrderId = x.SalesOrderId,
                    SalesOrderNumber = x.SalesOrderNumber,
                    ShipDate = x.ShipDate
                })
                .Take(PageSize)
                .ToList();

            var results = new List<SalesOrderHeader>();

            foreach (var salesOrderHeader in salesOrderHeaders)
            {
                results.Add(salesOrderHeader);
            }
        }
    }
}