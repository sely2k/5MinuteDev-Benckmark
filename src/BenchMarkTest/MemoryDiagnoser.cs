using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace BenchMarkTest
{
    [SimpleJob(RuntimeMoniker.NetCoreApp31, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp50)]

    [MemoryDiagnoser]

    //[ThreadingDiagnoser]
    public class MemoryDiagnoser
    {

        [Benchmark(Baseline = true)]
        public List<int> lst()
        {
            return new List<int>(32);
        }

        [Benchmark]
        public int[] arr()
        {
            return new int[32];
        }
    }
}
