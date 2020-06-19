using System;
using System.IO;

namespace DisposeProj
{
  class Program
  {
    static void Main(string[] args)
    {
      
      try
      {
        using (StreamReader sr = new StreamReader(""))
        {
          sr.Read();

        }
      }
      finally
      {

      }

      Console.WriteLine("Hello World!");
    }
  }
}
