using System;
using System.Diagnostics;
using Reflection;

namespace Reflection3
{
  public class Program
  {
    public static void Main()
    {
      var myClass = new MyClass();
      var type = myClass.GetType();

      var method = type.GetMethod("Method");
      Stopwatch stopwatch = new Stopwatch();
      int length = 100000;
      stopwatch.Start();
      for (int i = 0; i < length; i++)
      {
        myClass.Method(1, 2);
      }
      stopwatch.Stop();
      Console.WriteLine($"Execute time: {stopwatch.ElapsedTicks}");

      stopwatch.Restart();
      for (int i = 0; i < length; i++)
      {
        method.Invoke(myClass, new object[] { 1, 2 });
      }
      stopwatch.Stop();
      Console.WriteLine($"Reflection invoke time: {stopwatch.ElapsedTicks}");
    }
  }
}
