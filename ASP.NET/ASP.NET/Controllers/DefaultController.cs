using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
  public class DefaultController : ApiController
  {
    [System.Web.Http.HttpGet]
    public PersonViewModel GetPerson()
    {
      return new PersonViewModel() { Name = "Пётр", Age = 70 };
    }
  }
}
