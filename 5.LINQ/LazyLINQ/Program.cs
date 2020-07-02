using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LazyLINQ
{
  public class Program
  {
    public static void Main()
    {
      int capacity = 100000000;
      ICollection<int> ints = new List<int>(capacity);
      Random random = new Random();
      for (int i = 0; i < capacity; i++)
      {
        ints.Add(random.Next(int.MinValue, int.MaxValue));
      }

      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      var list = ints.Where(number => number > 0);

      stopwatch.Stop();

      Console.WriteLine($"Ticks: {stopwatch.Elapsed}");
      Console.ReadKey();
    }
  }
}
