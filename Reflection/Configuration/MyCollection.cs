using System.Configuration;

namespace Configuration
{
  [ConfigurationCollection(typeof(MyElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
  public class MyCollection : ConfigurationElementCollection
  {
    protected override ConfigurationElement CreateNewElement()
    {
      return new MyElement();
    }
    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((MyElement)element).MySettingKey;
    }
  }
}
