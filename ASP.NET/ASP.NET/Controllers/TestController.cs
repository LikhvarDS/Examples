using ASP.NET.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  public class TestController : Controller
  {
    private readonly IMyService service;

    [HttpGet]
    public ViewResult Person()
    {
      var person = new PersonViewModel() { Name = "Пётр", Age = 70 };
      return this.View("PersonPage", person);
    }

    [HttpGet]
    public int Sum(int x, int y)
    {
      return x + y;
    }

    [HttpGet]
    public int Answer()
    {
      return this.service.GetAnswer();
    }

    public TestController(IMyService service)
    {
      this.service = service;
    }
  }
}