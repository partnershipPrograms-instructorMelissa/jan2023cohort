using Microsoft.AspNetCore.Mvc;

namespace ContactController.Controllers;

public class ContactController : Controller
{
  [HttpGet]
  [Route("contact")]

  public string Contact()
  {
    return "This is my contact!";
  }
}