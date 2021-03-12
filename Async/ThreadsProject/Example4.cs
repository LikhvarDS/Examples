using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ThreadsProject
{
  public class Example4
  {
    public static void Main()
    {
      var allDone = new ManualResetEvent(false);
      var result = new ConcurrentBag<int>();
      var completedTasks = 0;
      var threadCounts = 2;

      Action<Example3Args> method = args =>
      {
        for (int i = args.Start; i < args.Start + args.NumbersCount; i++)
        {
          args.Result.Add(i);
        }

        if (Interlocked.Increment(ref completedTasks) == threadCounts)
        {
          allDone.Set();
        }
      };

      var args1 = new Example3Args() { Start = 0, NumbersCount = 50, Result = result };
      var args2 = new Example3Args() { Start = 50, NumbersCount = 50, Result = result };

      ThreadPool.QueueUserWorkItem(method, args1, false);
      ThreadPool.QueueUserWorkItem(method, args2, false);

      allDone.WaitOne();

      foreach (var i in result)
        Console.WriteLine(i);
    }
  }
}
