﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadsProject
{
  public class Example1
  {
    public static void Main()
    {
      var result = new List<int>(200);

      ParameterizedThreadStart method = obj =>
      {
        var args = (Example1Args)obj;
        for (int i = args.Start; i < args.Start + args.NumbersCount; i++)
          args.Result.Add(i);

        //throw new Exception("TestException");
      };

      var thread1 = new Thread(method);
      var thread2 = new Thread(method);

      var args1 = new Example1Args() { Start = 0, NumbersCount = 50, Result = result };
      var args2 = new Example1Args() { Start = 50, NumbersCount = 50, Result = result };

      thread1.Start(args1);
      thread2.Start(args2);


      thread1.Join();
      thread2.Join();

      foreach (var i in result)
        Console.WriteLine(i);
    }
  }
}
