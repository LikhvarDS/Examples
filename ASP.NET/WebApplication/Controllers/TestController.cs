using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  public class TestController : Controller
  {
    [HttpGet]
    public ViewResult Person()
    {
      var person = new PersonViewModel() { Name = "Пётр", Age = 70 };
      return this.View("PersonPage", person);
    }


    [HttpGet]
    public void Sum(int x, int y)
    {

    }

    [HttpPost]
    public ActionResult GetPerson()
    {
      return this.Json(new PersonViewModel() { Name = "Пётр", Age = 70 });
    }
  }
}