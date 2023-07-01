using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.CommonCode.Reflections
{
    public class DestinationClass_Mapper : ApplyOrderFactory<DestinationClass, SourceClass>
    {
        public DestinationClass_Mapper(IConfiguration configuration)
        {
            Console.WriteLine($"Calling Constructor: {configuration["SomeKey"]} from Class: {GetType().Name}");

            Map(d => d.DestinationMax, s => s.SourceMax);
            Map(d => d.DestinationCount, s => s.SourceCount);
        }
    }

    public class DestinationClass2_Mapper : ApplyOrderFactory<DestinationClass2, SourceClass>
    {
        public DestinationClass2_Mapper(IConfiguration configuration)
        {
            Console.WriteLine($"Calling Constructor: {configuration["SomeKey"]} from Class: {GetType().Name}");

            Map(d => d.DestinationMax2, s => s.SourceMax);
            Map(d => d.DestinationCount2, s => s.SourceCount);
        }
    }

    public class SourceClass
    {
        public int SourceMax { get; set; }
        public int SourceCount { get; set; }
    }

    public class DestinationClass
    {
        public int DestinationMax { get; set; }
        public int DestinationCount { get; set; }
    }

    public class DestinationClass2
    {
        public int DestinationMax2 { get; set; }
        public int DestinationCount2 { get; set; }
    }
}
