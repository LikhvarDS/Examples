using System.Collections.Generic;

namespace TestedProject
{
  public class Store
  {
    private readonly Dictionary<string, object> parameters = new Dictionary<string, object>();

    public void SetParam(string paramKey, object parameter)
    {
      this.parameters[paramKey] = parameter;
    }

    public object GetParam(string paramKey)
    {
      return this.parameters[paramKey];
    }
  }
}
