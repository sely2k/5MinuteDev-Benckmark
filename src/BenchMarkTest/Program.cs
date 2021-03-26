using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;


namespace BenchMarkTest
{
    class Program
    {
        public static void Main(string[] args)
        {


            var types = new[] { typeof(Md5VsSha256), typeof(MemoryDiagnoser), typeof(SimpleMath)};
            var switcher = new BenchmarkSwitcher(types);

            switcher.Run(args, new DebugInProcessConfig());

            Console.ReadLine();
        }
    }
}
