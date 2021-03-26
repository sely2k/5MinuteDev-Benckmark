
using System;
using BenchmarkDotNet.Attributes;

namespace BenchMarkTest
{
    public class SimpleMath
    {
        [Params(100, 200)]
        public int N { get; set; }


        [Benchmark]
        public int LongExectution()
        {
            int sum = 0;

            for(int i = 0; i <= N; i++)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark(Baseline = true)]
        public int ShortExecution()
        { 
            return (N*(N + 1)) / 2;
        }
    }
}
