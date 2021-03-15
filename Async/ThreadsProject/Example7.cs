using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsProject
{
  public class Example7
  {
    public static void Main()
    {
      var tokenSource = new CancellationTokenSource();

      Task.Run(() => SlowMethod(tokenSource), tokenSource.Token);

      Thread.Sleep(TimeSpan.FromSeconds(3));
      tokenSource.Cancel();

      Console.WriteLine("Конец метода Main()");
      Console.ReadKey();
    }

    public static void SlowMethod(CancellationTokenSource token)
    {
      for (int i = 0; i < 1000000; i++)
      {
        Thread.Sleep(100);

        if (token.IsCancellationRequested)
        {
          Console.WriteLine("Метод отменён.");
          return;
        }
      }

      Console.WriteLine("Метод отработал.");
    }
  }
}
