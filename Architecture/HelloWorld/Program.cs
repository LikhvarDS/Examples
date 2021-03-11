using System;

namespace HelloWorld
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Сборка для просмотра в ILdasm.

      int a = 2 + 2;
      int b = a + 4;
      string c = "Hello, world!";
      Console.WriteLine(c);
    }
  }
}
