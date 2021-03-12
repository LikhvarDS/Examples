namespace WebApplication.Models
{
  public class Employee : PersonViewModel
  {
    public Employee Boss { get; set; }
  }
}