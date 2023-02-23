using Microsoft.AspNetCore.Mvc;

namespace ProjectsController.Controllers;

public class ProjectsController : Controller
{
  [HttpGet]
  [Route("projects")]
  public string Projects()
  {
    return "These are my projects!";
  }
}
