using System;
using System.Configuration;

namespace Configuration
{
  public class Program
  {
    public static void Main()
    {
      foreach(var key in ConfigurationManager.AppSettings.AllKeys)
      {
        Console.WriteLine(key);
      }
      Console.ReadKey();

      var settingsSection = (MySection)ConfigurationManager.GetSection("MySettings");
      Console.ReadKey();
    }
  }
}
