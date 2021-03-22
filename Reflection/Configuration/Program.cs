using System;
using System.Configuration;

namespace Configuration
{
  public class Program
  {
    public static void Main()
    {
      foreach (var key in ConfigurationManager.AppSettings.AllKeys)
        Console.WriteLine(key);

      Console.ReadKey();


      var settingsSection = (MySection)ConfigurationManager.GetSection("MySettings");
      foreach (MyElement setting in settingsSection.MySettings)
        Console.WriteLine($"{setting.MySettingKey}: {setting.MySettingValue}");

      Console.ReadKey();
    }
  }
}
