using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;

namespace Exercise.CommonCode.Benchmarks.Linq;

[MemoryDiagnoser(false)]
[Config(typeof(BenchmarkConfig))]
[RankColumn]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
public class SingleDefaultAndFirstDefaultBenchmark
{
    [Params("Human 10")]
    public string? Parameters { get; set; }

    private readonly IList<KeyValuePair<int, string>> _items = new List<KeyValuePair<int, string>>();

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 1; i <= 1000; i++)
        {
            _items.Add(new KeyValuePair<int, string>(i, $"Human {i}"));
        }
    }

    [Benchmark(Baseline = true)]
    public KeyValuePair<int, string> Single_Or_Default() => _items.Where(x => x.Value == Parameters).SingleOrDefault();

    [Benchmark]
    public KeyValuePair<int, string> First_Or_Default() => _items.Where(x => x.Value == Parameters).FirstOrDefault();

    [Benchmark]
    public KeyValuePair<int, string> Single_Or_Default_Without_Where() => _items.SingleOrDefault(x => x.Value == Parameters);

    [Benchmark]
    public KeyValuePair<int, string> First_Or_Default_Without_Where() => _items.FirstOrDefault(x => x.Value == Parameters);
}