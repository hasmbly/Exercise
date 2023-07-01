using BenchmarkDotNet.Attributes;

namespace Exercise.CommonCode.Benchmarks.Class
{
    [MemoryDiagnoser(false)]
    [Config(typeof(BenchmarkConfig))]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class OpenAndSealedClassBenchmark
    {
        private readonly OpenClass _openClass = new();
        private readonly SealedClass _sealedClass = new();
        private readonly RecordClass _recordClass = new();

        [Params(1000)]
        public int Size { get; set; }

        [Benchmark]
        public void OpenVoid() => _openClass.VoidMethod(Size);

        [Benchmark]
        public void SealedVoid() => _sealedClass.VoidMethod(Size);

        [Benchmark]
        public void RecorddVoid() => _recordClass.VoidMethod(Size);
    }

    public class OpenClass
    {
        public void VoidMethod(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }
    }

    public sealed class SealedClass
    {
        public void VoidMethod(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }
    }

    public record RecordClass()
    {
        public void VoidMethod(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }
    }
}