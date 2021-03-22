using System;

namespace TestedProject
{
  public class StringService : IDisposable
  {
    private Store store;

    public string GetString()
    {
      return "Hello, World!";
    }

    public string GetString(string name)
    {
      return $"Hello, {name}!";
    }

    public string GetStringWithDefaultName()
    {
      return "Hello, " + this.store.GetParam("DefaultName").ToString() + "!";
    }

    public void SetStore(Store store)
    {
      this.store = store;
    }

    public string ConcatStrings(string first, string second)
    {
      return first + second;
    }

    public void Dispose()
    {
      // demo TearDown
    }
  }
}
