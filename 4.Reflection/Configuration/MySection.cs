using System.Configuration;

namespace Configuration
{
  public class MySection : ConfigurationSection
  {
    [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = false)]
    public MyCollection MySettings => (MyCollection)this[string.Empty];
  }
}

