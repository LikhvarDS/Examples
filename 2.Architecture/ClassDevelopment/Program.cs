﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDevelopment
{
  class Program
  {
    /// <summary>
    /// Examles 2.
    /// </summary>
    public static void Main()
    {
      var examples = new Examples2();
      var message = examples.CallingMethod();
      Console.WriteLine(message);
    }
  }
}