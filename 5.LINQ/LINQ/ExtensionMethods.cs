using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
  public static class ExtensionMethods
  {
    public static void ConsoleWrite<T>(this IEnumerable<T> enumerable)
    {
      StringBuilder sb = new StringBuilder();

      foreach (var e in enumerable)
      {
        sb.Append(e).Append(' ');
      }

      sb.AppendLine();

      Console.WriteLine(sb.ToString());
    }
  }
}
