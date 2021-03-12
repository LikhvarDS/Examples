using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ThreadsProject
{
  public class Example6
  {
    public static void Main()
    {
      var result = new ConcurrentBag<int>();

      var args1 = new Example3Args() { Start = 0, NumbersCount = 50, Result = result };
      var args2 = new Example3Args() { Start = 50, NumbersCount = 50, Result = result };

      var task1 = Task.Run(() => AddIntsToBag1(args1));
      var task2 = AddIntsToBag2(args2);

      Task.WaitAll(task1, task2);
      foreach (var i in result)
        Console.WriteLine(i);

      /*
      Task.WhenAll(task1, task2).ContinueWith(async (obj) =>
      {
        foreach (var i in result)
          Console.WriteLine(i);
      });
      */
    }

    public static void AddIntsToBag1(object obj)
    {
      var args = (Example3Args)obj;
      for (int i = args.Start; i < args.Start + args.NumbersCount; i++)
        args.Result.Add(i);

      //throw new Exception("TestException");
    }

    public static async Task AddIntsToBag2(Example3Args args)
    {
      for (int i = args.Start; i < args.Start + args.NumbersCount; i++)
        args.Result.Add(i);
    }

    public static async Task<int> GetSomething()
    {
      return 42;
    }

    public static async Task WriteSomething()
    {
      var something = await GetSomething();
      Console.WriteLine(something);
    }
  }
}
