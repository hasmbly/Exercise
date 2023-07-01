using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace Exercise.CommonCode.Benchmarks
{
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig() => SummaryStyle = SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
    }
}