using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
  class Program
  {
    static void Main(string[] args)
    {
      // Language INtegrated Queries

      int[] numbersArray = new int[10] { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

      var result = Example1(numbersArray);
      //var result = Example2(numbersArray);


      result.ConsoleWrite();
      Console.ReadKey();
    }

    private static IEnumerable<int> Example1(int[] array)
    {
      var positives = from number in array
                      where number > 0
                      orderby number descending
                      select number;

      return positives;
    }

    private static IEnumerable<int> Example2(int[] array)
    {
      var positives = array.Where(number => number > 0).OrderByDescending(n => n);

      return positives;
    }
  }
}
