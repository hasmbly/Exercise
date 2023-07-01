using BenchmarkDotNet.Attributes;
using Exercise.CommonCode.Accurate.InconsistentData.Dto;
using System.Runtime.InteropServices;

namespace Exercise.CommonCode.Benchmarks.Loops
{
    [MemoryDiagnoser(false)]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class LoopsBenchmark
    {
        private static readonly Random _random = new(80085);

        [Params(1000)]
        public int Size { get; set; }

        private List<int> _items = new();

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(1, Size).Select(x => _random.Next()).ToList();
        }

        [Benchmark]
        public void For()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                var _ = new ClassDto
                {
                    Name = $"_items: {_items[i]}"
                };
            }
        }

        [Benchmark]
        public void Foreach()
        {
            foreach (var item in _items)
            {
                var _ = new ClassDto
                {
                    Name = $"_items: {item}"
                };
            }
        }

        [Benchmark]
        public void Foreach_Linq()
        {
            _items.ForEach(item =>
            {
                var _ = new ClassDto
                {
                    Name = $"_items: {item}"
                };
            });
        }

        [Benchmark]
        public void Foreach_Span()
        {
            foreach (var item in CollectionsMarshal.AsSpan(_items))
            {
                var _ = new ClassDto
                {
                    Name = $"_items: {item}"
                };
            }
        }
    }

    public class ClassDto
    {
        public string Name { get; set; } = default!;
    }
}