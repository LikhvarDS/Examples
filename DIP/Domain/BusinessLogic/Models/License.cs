namespace BusinessLogic.Models
{
  public class License
  {
    public string OwnerName { get; }

    public string Code { get; }

    public License(string name, string code)
    {
      this.OwnerName = name;
      this.Code = code;
    }
  }
}
