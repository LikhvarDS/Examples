using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class DefaultController : ApiController
    {


    [System.Web.Http.HttpGet]
    public Stream GetPerson()
    {
      return new PersonViewModel() { Name = "Пётр", Age = 70 };
    }
  }
}
