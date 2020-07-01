using System;

namespace Reflection
{
  public class Program
  {
    public static void Main()
    {
      var myClass = new MyClass();
      var type = myClass.GetType();
      type = typeof(MyClass);

      Console.WriteLine($"{nameof(type.Name)}: {type.Name}");
      Console.WriteLine($"{nameof(type.FullName)}: {type.FullName}");
      Console.WriteLine($"{nameof(type.Assembly)}: {type.Assembly.FullName}");
      Console.WriteLine($"{nameof(type.Namespace)}: {type.Namespace}");
      Console.WriteLine($"{nameof(type.GUID)}: {type.GUID}");
      Console.WriteLine($"Constructors count: {type.GetConstructors().Length}");
      Console.WriteLine();

      var method = type.GetMethod("Method");
      object result = method.Invoke(myClass, new object[] { 1, 2 });
      Console.WriteLine($"Result of Method(): {result}");
      Console.ReadKey();
    }
  }
}
