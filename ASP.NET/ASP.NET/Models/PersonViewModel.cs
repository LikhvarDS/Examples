namespace WebApplication.Models
{
  public class PersonViewModel
  {
    public string Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
      return this.Name;
    }
  }
}