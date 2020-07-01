using System.Configuration;

namespace Configuration
{
  public class MyElement : ConfigurationElement
  {
    [ConfigurationProperty(nameof(MySettingKey), IsRequired = true, IsKey = true)]
    public string MySettingKey
    {
      get { return (string)this[nameof(this.MySettingKey)]; }
    }

    [ConfigurationProperty(nameof(MySettingValue), IsRequired = true)]
    public int MySettingValue
    {
      get { return (int)this[nameof(this.MySettingValue)]; }
    }
  }
}
