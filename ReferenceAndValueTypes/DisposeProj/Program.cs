using System;
using System.IO;

namespace DisposeProj
{
  public class Program
  {
    public static void Main(string[] args)
    {
      using (var writer1 = new StreamWriter("test.txt"))
      {
        writer1.Write("42");
      }

      StreamWriter writer2 = null;
      try
      {
        writer2 = new StreamWriter("test2.txt");
        writer2.Write("42");
      }
      finally
      {
        writer2?.Dispose();
      }

      Console.WriteLine("Hello World!");
    }
  }
}
