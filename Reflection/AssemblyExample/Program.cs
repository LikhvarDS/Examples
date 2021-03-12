using System;
using System.IO;
using System.Reflection;

namespace AssemblyExample
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Загруженные сборки:");
      foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        Console.WriteLine(assembly.FullName);
      }
      Console.WriteLine();
      Console.ReadKey();

      var currentDirectory = Directory.GetCurrentDirectory();
      var assemblyName = "HelloWorldClassLibrary.dll";
      var path = Path.Combine(currentDirectory, assemblyName);
      var helloAssembly = Assembly.LoadFrom(path);

      Console.WriteLine("Загруженные сборки:");
      foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        Console.WriteLine(assembly.FullName);
      }
      Console.WriteLine();
      Console.ReadKey();

      var helloType = helloAssembly.GetType("HelloWorldClassLibrary.HelloWorldClass");
      var property = helloType.GetProperty("Property");
      Console.WriteLine($"{property.Name}: {property.GetValue(null)}");
      Console.ReadKey();
    }
  }
}
