using System;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ConsoleApp1;
using NUnit.Framework;

namespace UnitTestProject
{
  [TestFixture]
  public class BenchmarkTestsExample
  {
    [Test]
    public void ParallelFilterPerformanceTest()
    {
      var sw = new Stopwatch();

      var filter = new ParallelFilter(10, 100);
      var random = new Random();
      var data = Enumerable.Range(1, 1000000).OrderBy(_ => random.Next()).ToArray();

      sw.Start();

      filter.Search(data, d => d % 2 == 0);

      sw.Stop();

      Assert.GreaterOrEqual(TimeSpan.FromSeconds(1), sw.Elapsed);
    }







    private class ParallelFilterBenchmark
    {
      [Params(10, 50, 100)]
      public int maxTasks;
      [Params(100, 500, 1000)]
      public int minElements;

      private ParallelFilter filter;
      private int[] data;

      [GlobalSetup]
      public void GlobalSetup()
      {
        this.filter = new ParallelFilter(10, 100);
        var random = new Random();
        this.data = Enumerable.Range(1, 1000000).OrderBy(_ => random.Next()).ToArray();
      }


      [Benchmark(Description = "Search")]
      public void SearchBenchmark()
      {
        this.filter.Search(data, d => d % 2 == 0);
      }
    }

    [Test]
    public void ParallelFilterBenchmarkTest()
    {
      BenchmarkRunner.Run<ParallelFilterBenchmark>();
    }
  }
}
