using System;
using System.Collections.Generic;
using System.Diagnostics;
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
      //var result = Example3();
      //Example4();

      result.ConsoleWrite();
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
      var positives = array
        .Where(number => number > 0)
        .OrderByDescending(n => n);

      return positives;
    }

    private static IEnumerable<string> Example3()
    {
      var persons = Person.CreateTestData();

      var names = persons
        .Where(person => person.Id != 0)
        .Where(person => person.Age >= 18)
        .OrderBy(p => p.Age)
        .Take(10)
        .Select(p => p.Name);

      return names;
    }

    private static void Example4()
    {
      Random rnd = new Random();
      var array = Enumerable.Range(1, 1000000).OrderBy(_ => rnd.Next()).ToArray();

      var stopwatch = new Stopwatch();

      stopwatch.Start();

      var sortedArray = array
        .OrderByDescending(n => n);

      stopwatch.Stop();

      Console.WriteLine(stopwatch.Elapsed);
    }
  }
}
