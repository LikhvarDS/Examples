namespace Reflection
{
  public class MyClass
  {
    public const string ConstantString = "This is constant";
    private readonly string field = "Field";

    internal string Property { get; } = "Internal property";

    public string Method(int i, int j)
    {
      return $"Public Method. i = {i}, j = {j}.";
    }
  }
}
