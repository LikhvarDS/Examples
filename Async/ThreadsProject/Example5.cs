using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsProject
{
  public class Example5
  {
    public static void Main()
    {
      var result = new ConcurrentBag<int>();

      Action<Example3Args> method = args =>
      {
        for (int i = args.Start; i < args.Start + args.NumbersCount; i++)
        {
          args.Result.Add(i);
        }
      };

      var args1 = new Example3Args() { Start = 0, NumbersCount = 50, Result = result };
      var args2 = new Example3Args() { Start = 50, NumbersCount = 50, Result = result };

      Parallel.Invoke(
        () => method.Invoke(args1),
        () => method.Invoke(args2)
      );

      foreach (var i in result)
        Console.WriteLine(i);
    }
  }
}
