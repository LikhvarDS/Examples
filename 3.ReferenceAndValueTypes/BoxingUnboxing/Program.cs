using System;
using System.Diagnostics;

namespace BoxingUnboxing
{
  class Program
  {
    private const int CycleLength = 100000000;

    public static void BoxingExampleForILDasm()
    {
      int i = 0;
      // Boxing.
      object o = i;
      // Unboxing.
      int j = (int)o;

      int k = i;
    }

    static void Main(string[] args)
    {
      Stopwatch stopwatch = new Stopwatch();
      object tempObject;
      int tempNumber;


      stopwatch.Restart();

      for (var i = 0; i < CycleLength; i++)
      {
        tempObject = (object)i;
      }

      stopwatch.Stop();
      Console.WriteLine(stopwatch.Elapsed);
      stopwatch.Restart();

      for (var i = 0; i < CycleLength; i++)
      {
        tempNumber = i;
      }

      stopwatch.Stop();
      Console.WriteLine(stopwatch.Elapsed);
    }
  }
}
