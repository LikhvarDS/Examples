using System;
using Reflection;

namespace Reflection2
{
  public class Program
  {
    public static void Main()
    {
      var myClass = new MyClass();
      var type = myClass.GetType();

      var fields = type.GetFields(/*BindingFlags.NonPublic | BindingFlags.Instance*/);
      foreach (var field in fields)
      {
        Console.WriteLine($"{field.Name}: {field.GetValue(myClass)}");
      }
      Console.ReadKey();

      var constF = fields[0];
      Console.WriteLine($"Name: {constF.Name}");
      Console.WriteLine($"Old Value: {constF.GetValue(myClass)}");
      constF.SetValue(myClass, "F");
      Console.WriteLine($"New Value: {constF.GetValue(myClass)}");
      Console.ReadKey();
    }
  }
}
