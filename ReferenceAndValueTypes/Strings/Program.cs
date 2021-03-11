using System;

namespace Strings
{
  class Program
  {
    static void Main(string[] args)
    {
      int i1 = 1;
      int i2 = 1;
      Console.WriteLine($"i1 == i2: {i1 == i2}");

      object o1 = (object)i1;
      object o2 = (object)i1;
      Console.WriteLine($"o1 == o2: {o1 == o2}");


      string s1 = "Hello";
      string s2 = "Hello";
      Console.WriteLine($"s1 == s2: {s1 == s2}");

      o1 = (object)s1;
      o2 = (object)s2;
      Console.WriteLine($"o1 == o2: {o1 == o2}");

      Console.WriteLine($"\"Hello\" is interned: {string.IsInterned(s1) != null}");
    }
  }
}
